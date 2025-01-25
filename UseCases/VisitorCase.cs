using Patterns.Patterns.Visitor;

namespace Patterns.UseCases
{
    public class VisitorCase : IUseCase
    {
        public void Run()
        {
            Console.WriteLine(nameof(VisitorCase));

            var circle = new Circle(5);
            var square = new Square(5);

            var areaCalculator = new AreaCalculator();

            circle.Accept(areaCalculator);
            square.Accept(areaCalculator);
        }
    }
}
