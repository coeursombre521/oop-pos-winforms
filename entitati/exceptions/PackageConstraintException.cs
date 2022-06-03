
namespace entitati {
    public class PackageConstraintException : Exception {
        public PackageConstraintException() { }

        public PackageConstraintException(string message) : base(message) { }
        
        public PackageConstraintException(string message, Exception inner) : base(message, inner) { }
    }
}