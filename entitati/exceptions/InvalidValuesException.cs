namespace entitati {
    public class InvalidValuesException : Exception {
        public InvalidValuesException() { }

        public InvalidValuesException(string message) : base(message) { }

        public InvalidValuesException(string message, Exception inner) : base(message, inner) { }
    }
}
