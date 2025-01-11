using Patterns.Patterns;

namespace Patterns.UseCases
{
    internal class BuilderCase : IUseCase
    {
        public void Run()
        {
            Console.WriteLine(nameof(BuilderCase));

            var oldStyleBuilder = new FossileFurelCarBuilder();
            var director = new Director(oldStyleBuilder);

            director.Construct();
            oldStyleBuilder.Vechicle.PrintSpecification();

            var futureStyleBuilder = new FutureFlyingCar();
            director = new Director(futureStyleBuilder);
            director.Construct();

            futureStyleBuilder.Vechicle.PrintSpecification();
        }
    }
}
