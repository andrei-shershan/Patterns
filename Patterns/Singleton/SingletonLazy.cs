namespace Patterns.Patterns.Singleton
{
    internal class SingletonLazy: SigletonBase
    {
        private static readonly Lazy<SingletonLazy> _lazyInstance =
            new Lazy<SingletonLazy>(() => new SingletonLazy());

        private SingletonLazy()
        {
        }

        public static SingletonLazy Instance => _lazyInstance.Value;
    }
}
