namespace Patterns.Patterns.Singleton
{
    public sealed class SingletonUnsafe: SigletonBase
    {
        private static SingletonUnsafe? _instance;

        private SingletonUnsafe() { }

        public static SingletonUnsafe Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SingletonUnsafe();
                }
                return _instance;
            }
        }
    }
}
