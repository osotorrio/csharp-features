namespace CSharp.V1
{
    public class Properties
    {
        private string _internalStore;

        public string ClassicalProperty
        {
            get { return _internalStore; }
            set { _internalStore = value; }
        }

        public string ExpressionBodiedProperty
        {
            get => _internalStore;
            set => _internalStore = value;
        }

        public string AutoProperty { get; set; }

        public string AutoPropertyInitialized { get; set; } = string.Empty;

        public string ClassOnlyProperty { get; private set; } = string.Empty; // Can be set only from the code of this class

        public string ConstructorOnlyProperty { get; } = string.Empty; // Can be set only from constructor

        public static string ReadOnlyProperty => string.Empty; // Same as: { get => string.Empty; }

        public string ReadOnlyComputedProperty => AutoProperty + AutoPropertyInitialized;
    }
}