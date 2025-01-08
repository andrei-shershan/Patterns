using Patterns.Patterns.Singleton;

namespace Patterns.UseCases
{
    internal class SingletonCase
    {
        public void Run()
        {
            var incrementor = new Incrementor();
            var multiplier = new Multiplier();

            incrementor.AddToCounter(10);
            multiplier.Multiply(2);

            if (SignletonUnsafe.Instance.Counter == 20)
            {
                System.Console.WriteLine("Singleton works, the counter is 20");
            }
            else
            {
                System.Console.WriteLine("Singleton failed, the counter is not 20");
            }
        }
    }

    internal class Incrementor
    {
        public void AddToCounter(int i)
        {
            SignletonUnsafe.Instance.Counter += i;
        }
    }

    internal class Multiplier
    {
        public void Multiply(int i)
        {
            SignletonUnsafe.Instance.Counter *= i;
        }
    }
}
