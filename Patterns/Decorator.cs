namespace Patterns.Patterns
{
    public abstract class Component
    {
        public abstract void Operation();
    }

    public class BaseComponent : Component 
    {
        public override void Operation()
        {
            System.Console.WriteLine("BaseComponent.Operation()");
        }
    }

    public abstract class Decorator : Component
    {
        private readonly Component _component;

        public Decorator(Component component)
        {
            _component = component;
        }

        public override void Operation()
        {
            _component.Operation();
        }
    }

    public class ADecoratedComponent : Decorator
    {
        public ADecoratedComponent(Component component) : base(component)
        {
        }

        public override void Operation()
        {
            base.Operation();
            System.Console.WriteLine("ADecoratedComponent.Operation()");
        }
    }

    public class BDecoratedComponent : Decorator
    {
        public BDecoratedComponent(Component component) : base(component)
        {
        }

        public override void Operation()
        {
            base.Operation();
            System.Console.WriteLine("BDecoratedComponent.Operation()");
        }
    }
}
