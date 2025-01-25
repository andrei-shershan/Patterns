using Patterns.Patterns.TemplateMethod;

namespace Patterns.UseCases
{
    public class TemplateMethodCase : IUseCase
    {
        public void Run()
        {
            Console.WriteLine(nameof(TemplateMethodCase));

            var dbProcessror = new DbProcessor();
            dbProcessror.Process();

            var localProcessor = new LocalProcessor();
            localProcessor.Process();
        }
    }
}
