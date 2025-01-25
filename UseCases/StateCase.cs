using Patterns.Patterns.State;

namespace Patterns.UseCases
{
    public class StateCase : IUseCase
    {
        public void Run()
        {
            Console.WriteLine(nameof(StateCase));

            var document = new Document();

            document.Create();
            document.Save();

            document.Create();
            document.Publish();

            document.Create();
        }
    }
}
