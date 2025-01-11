using Patterns.Patterns;

namespace Patterns.UseCases
{
    internal class PrototypeCase : IUseCase
    {
        public void Run()
        {
            Console.WriteLine(nameof(PrototypeCase));

            IShape circle = new Circle(100);
            IShape rectangle = new Rectangle(10, 20);

            IShape clonedCircle = circle.Clone();
            IShape clonedRectangle = rectangle.Clone();

            circle.PrintDetails();
            clonedCircle.PrintDetails();

            CompareOpjects(nameof(Circle), circle, clonedCircle);

            rectangle.PrintDetails();
            clonedRectangle.PrintDetails();

            CompareOpjects(nameof(Rectangle), circle, clonedCircle);
        }

        private void CompareOpjects(string objectName, object obj1, object obj2)
        {
            var comparisonResult = obj1 == obj2 ? "Same object" : "Different object";
            Console.WriteLine($"{objectName}: {comparisonResult}");
        }
    }
}
