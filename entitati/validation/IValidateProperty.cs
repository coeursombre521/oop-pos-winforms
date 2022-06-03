namespace entitati {
    public delegate void BeforePropertyValidationEventHandler(object? sender, PropertyValidationDescriptorEventArgs e);
    public delegate void AfterPropertyValidationEventHandler(object? sender, PropertyValidationDescriptorEventArgs e);
    public delegate bool PropertyValidationDelegate<T>(T value);

    public interface IValidateProperty {
        event BeforePropertyValidationEventHandler? BeforePropertyValidation;
        event AfterPropertyValidationEventHandler? AfterPropertyValidation;
    }
}
