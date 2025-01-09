namespace Patterns.Patterns
{
    public interface IProduct
    {
        string GetName();
    }

    public class ConcreteProductA : IProduct
    {
        public string GetName() => "A";
    }

    public class ConcreteProductB : IProduct
    {
        public string GetName() => "B";
    }

    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public string SomeOperation()
        {
            var product = FactoryMethod();
            return product.GetName();
        }
    }

    public class ConcrentCreatorA : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }

    public class ConcrentCreatorB : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}
