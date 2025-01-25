using Patterns.Patterns;

namespace Patterns.UseCases
{
    public class CommandCase : IUseCase
    {
        public void Run()
        {
            Console.WriteLine(nameof(CommandCase));

            var invoker = new Invoker();
            var simpleCommand = new SimpleCommand("Simple command payload");

            invoker.SetCommand(simpleCommand);
            invoker.DoSomething();

            var complexCommand = new ComplexCommand(new Receiver(), "First", "Second");
            invoker.SetCommand(complexCommand);
            invoker.DoSomething();
        }
    }
}
