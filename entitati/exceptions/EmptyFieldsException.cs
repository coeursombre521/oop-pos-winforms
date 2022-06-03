namespace entitati {
    public class EmptyFieldsException : Exception {
        public EmptyFieldsException() { }

        public EmptyFieldsException(string message) : base(message) { }

        public EmptyFieldsException(string message, Exception inner) : base(message, inner) { }
    }
}
