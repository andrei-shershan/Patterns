using Patterns.Patterns;

namespace Patterns.UseCases
{
    public class DecoratorCase : IUseCase
    {
        public void Run()
        {
            Console.WriteLine(nameof(DecoratorCase));
         
            var baseComponent = new BaseComponent();
            baseComponent.Operation();

            var aDecoratedComponent = new ADecoratedComponent(baseComponent);
            aDecoratedComponent.Operation();

            var bDecoratedComponent = new BDecoratedComponent(aDecoratedComponent);
            bDecoratedComponent.Operation();
        }
    }
}
