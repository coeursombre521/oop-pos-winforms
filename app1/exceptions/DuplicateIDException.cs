namespace app1 {
    internal class DuplicateIDException : Exception {
        public DuplicateIDException() { }

        public DuplicateIDException(string message) : base(message) { }

        public DuplicateIDException(string message, Exception inner) : base(message, inner) { }
    }
}
