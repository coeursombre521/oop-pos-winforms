using System.Linq.Expressions;

namespace entitati {
    public static class PropertyValidation {
        public static bool RaiseEventsAndChangeIfValid<TField, TParent>(
            BeforePropertyValidationEventHandler handlerBefore,
            PropertyValidationDelegate<TField> handlerValidation,
            AfterPropertyValidationEventHandler handlerAfter,
            ref TField field,
            TField value,
            TParent parent,
            Expression<Func<TField>> memberExpression
        ) {
            if (memberExpression == null) {
                throw new ArgumentNullException("No lambda expression provided in parameter.");
            }
            var body = memberExpression.Body as MemberExpression;
            if (body == null) {
                throw new ArgumentException("Lambda must return a property.");
            }

            var vmExpression = body.Expression as ConstantExpression;

            if (vmExpression != null) {
                LambdaExpression lambda = Expression.Lambda(vmExpression);
                Delegate vmFunc = lambda.Compile();
                object? sender = vmFunc.DynamicInvoke();

                handlerBefore?.Invoke(sender, new PropertyValidationDescriptorEventArgs(nameof(field), parent, value, false));

                if (handlerValidation != null) {
                    bool ret = false; 
                    ret = handlerValidation(value);
                    if (ret) {
                        field = value;
                        handlerAfter?.Invoke(sender, new PropertyValidationDescriptorEventArgs(nameof(field), parent, value, false));
                    }
                    else {
                        handlerAfter?.Invoke(sender, new PropertyValidationDescriptorEventArgs(nameof(field), parent, value, true));
                    }
                }
            }

            return true;
        }
    }
}
