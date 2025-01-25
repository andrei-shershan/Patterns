namespace Patterns.Patterns
{
    namespace Visitor
    {
        public interface IVisitor
        {
            void Visit(Circle circle);
            void Visit(Square square);

        }

        public interface IShape
        {
            void Accept(IVisitor visitor);
        }

        public class Circle : IShape
        {
            public int Radius { get; private set; }

            public Circle(int radius)
            {
                Radius = radius;
            }

            public void Accept(IVisitor visitor)
            {
                visitor.Visit(this);
            }
        }

        public class Square : IShape
        {
            public int Side { get; private set; }

            public Square(int side)
            {
                Side = side;
            }

            public void Accept(IVisitor visitor)
            {
                visitor.Visit(this);
            }
        }

        public class AreaCalculator : IVisitor
        {
            public void Visit(Circle circle)
            {
                Console.WriteLine($"Area of circle with radius {circle.Radius} is {Math.PI * circle.Radius * circle.Radius}");
            }

            public void Visit(Square square)
            {
                Console.WriteLine($"Area of square with side {square.Side} is {square.Side * square.Side}");
            }
        }
    }
}
