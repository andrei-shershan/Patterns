using Patterns.Patterns.Singleton;

namespace Patterns.UseCases
{
    internal class SingletonCase
    {
        public void UnsafeCase()
        {
            IncrementUnsafeSingletonCounter(10);
            MultiplyUnsafeSingletonCounter(2);

            if (SignletonUnsafe.Instance.Counter == 20)
            {
                Console.WriteLine("Unsafe Singleton works, the counter is 20");
            }
            else
            {
                Console.WriteLine("Unsafe Singleton failed, the counter is not 20");
            }
        }

        public void LazyCase()
        {
            IncrementLazySingletonCounter(10);
            MultiplyLazySingletonCounter(2);

            if (SignletonUnsafe.Instance.Counter == 20)
            {
                Console.WriteLine("Lazy Singleton works, the counter is 20");
            }
            else
            {
                Console.WriteLine("Lazy Singleton failed, the counter is not 20");
            }
        }

        private void IncrementUnsafeSingletonCounter(int i)
        {
            SignletonUnsafe.Instance.Counter += i;
        }

        private void IncrementLazySingletonCounter(int i)
        {
            SingletonLazy.Instance.Counter += i;
        }

        private void MultiplyUnsafeSingletonCounter(int multiplier)
        {
            SignletonUnsafe.Instance.Counter *= multiplier;
        }

        private void MultiplyLazySingletonCounter(int multiplier)
        {
            SingletonLazy.Instance.Counter *= multiplier;
        }
    }
}
