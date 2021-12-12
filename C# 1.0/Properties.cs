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

        public string ReadOnlyProperty { get; private set; } // Can be set only from the code of this class

        public string OnlyConstructorProperty { get; } // Can be set only from constructor or property initializer.

        public IEnumerable<string> InitializerProperty { get; } = new List<string>();

        public string ComputedProperty => InitializerProperty.Last();
    }
}