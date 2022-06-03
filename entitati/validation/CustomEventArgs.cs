namespace entitati {
    public class PropertyValidationDescriptorEventArgs : EventArgs {
        public string? PropertyName { get; private set; }
        public object? ParentObject { get; private set; }
        public object? NewValue { get; private set; }
        public bool OnErrorCondition { get; private set; }

        public PropertyValidationDescriptorEventArgs(string? propertyName, object? parentObject, object? newValue, bool onErrorCondition) : base() {
            PropertyName = propertyName;
            ParentObject = parentObject;
            NewValue = newValue;
            OnErrorCondition = onErrorCondition;
        }
    }
}
