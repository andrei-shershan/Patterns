using Patterns.Patterns;

namespace Patterns.UseCases
{
    internal class FabricMethodCase
    {
        public void Run()
        {
            Console.WriteLine(nameof(FabricMethodCase));

            var creatorA = new ConcrentCreatorA();
            var creatorB = new ConcrentCreatorB();

            Console.WriteLine(creatorA.SomeOperation());
            Console.WriteLine(creatorB.SomeOperation());
        }
    }
}
