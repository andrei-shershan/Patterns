namespace Patterns.Patterns
{
    public interface IShape
    {
        IShape Clone();
        void PrintDetails();
    }

    public class Rectangle : IShape
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public IShape Clone()
        {
            return new Rectangle(this.Width, this.Height);
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Rectangle: Width={Width}, Height={Height}");
        }
    }

    public class Circle : IShape
    {
        public int Radius { get; set; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public IShape Clone()
        {
            return new Circle(this.Radius);
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Circle: Radius={Radius}");
        }
    }
}
