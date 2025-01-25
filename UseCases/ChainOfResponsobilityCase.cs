using static Patterns.Patterns.Handler;

namespace Patterns.UseCases
{
    public class ChainOfResponsobilityCase : IUseCase
    {
        public void Run()
        {
            Console.WriteLine(nameof(ChainOfResponsobilityCase));

            var validationHandler = new ValidationHandler();
            var saveDataHandler = new SaveDataHandler();
            var loggerHandler = new LogHandler();

            validationHandler.SetNext(saveDataHandler).SetNext(loggerHandler);

            Console.WriteLine(validationHandler.Handle("Some data"));
        }
    }
}
