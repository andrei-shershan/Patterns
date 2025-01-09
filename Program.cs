using Patterns.UseCases;

namespace Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var unsafeSingletonCase = new UnsafeSingletonCase();
            unsafeSingletonCase.Run();

            var lazySingletonCase = new LazySingletonCase();
            lazySingletonCase.Run();

            var fabricMethodCase = new FabricMethodCase();
            fabricMethodCase.Run();

            var abstractFactoryCase = new AbstractFactoryCase();
            abstractFactoryCase.Run();
        }
    }
}
