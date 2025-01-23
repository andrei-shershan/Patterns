using Patterns.Patterns;

namespace Patterns.UseCases
{
    public class FacadeCase : IUseCase
    {
        public void Run()
        {
            Console.WriteLine(nameof(FacadeCase));

            var subsystemA = new SubsystemA();
            var subsystemB = new SubsystemB();

            var facade = new Facade(subsystemA, subsystemB);
            facade.Operation();
        }
    }
}
