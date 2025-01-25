using Patterns.Patterns.Strategy;

namespace Patterns.UseCases
{
    public class StrategyCase : IUseCase
    {
        public void Run()
        {
            Console.WriteLine(nameof(StrategyCase));
            
            var context = new Context();

            context.SetStrategy(new WebBrowser());
            context.DoSomething();

            context.SetStrategy(new AiAgent());
            context.DoSomething();
        }
    }
}
