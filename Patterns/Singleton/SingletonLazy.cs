namespace Patterns.Patterns.Singleton
{
    internal class SingletonLazy
    {
        private static readonly Lazy<SingletonLazy> _lazyInstance =
            new Lazy<SingletonLazy>(() => new SingletonLazy());

        private SingletonLazy()
        {
        }

        public int Counter { get; set; }

        public static SingletonLazy Instance => _lazyInstance.Value;
    }
}
