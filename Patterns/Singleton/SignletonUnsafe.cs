namespace Patterns.Patterns.Singleton
{
    public sealed class SignletonUnsafe
    {
        private static SignletonUnsafe? _instance;

        private SignletonUnsafe() { }

        public int Counter { get; set; }

        public static SignletonUnsafe Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SignletonUnsafe();
                }
                return _instance;
            }
        }
    }
}
