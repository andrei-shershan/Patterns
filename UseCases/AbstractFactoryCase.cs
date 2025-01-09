using Patterns.Patterns;

namespace Patterns.UseCases
{
    internal class AbstractFactoryCase : IUseCase
    {
        public void Run()
        {
            Console.WriteLine(nameof(AbstractFactoryCase));

            var factory = new Application(new WindowsFactory());
            factory.RenderElement();

            factory = new Application(new LinuxFactory());
            factory.RenderElement();
        }
    }
}
