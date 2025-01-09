using Patterns.Patterns.Singleton;

namespace Patterns.UseCases
{
    internal class UnsafeSingletonCaseCreateor : UseCaseCreator
    {
        public override IUseCase Create()
        {
            return new UnsafeSingletonCase();
        }
    }

    internal class LazySingletonCaseCreateor : UseCaseCreator
    {
        public override IUseCase Create()
        {
            return new LazySingletonCase();
        }
    }

    internal class UnsafeSingletonCase : IUseCase
    {
        public void Run()
        {
            Console.WriteLine(nameof(UnsafeSingletonCase));
            SingletonUnsafe.Instance.IncrementCounter(10);
            SingletonUnsafe.Instance.MultiplyCounter(2);

            if (SingletonUnsafe.Instance.Counter == 20)
            {
                Console.WriteLine("Unsafe Singleton works, the counter is 20");
            }
            else
            {
                Console.WriteLine("Unsafe Singleton failed, the counter is not 20");
            }
        }

    }

    internal class LazySingletonCase : IUseCase
    {
        public void Run()
        {
            Console.WriteLine(nameof(LazySingletonCase));

            SingletonLazy.Instance.IncrementCounter(10);
            SingletonLazy.Instance.MultiplyCounter(2);

            if (SingletonLazy.Instance.Counter == 20)
            {
                Console.WriteLine("Unsafe Singleton works, the counter is 20");
            }
            else
            {
                Console.WriteLine("Unsafe Singleton failed, the counter is not 20");
            }
        }
    }
}

