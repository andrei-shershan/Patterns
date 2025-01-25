using Patterns.Patterns.Memento;

namespace Patterns.UseCases
{
    public class MementoCase : IUseCase
    {
        public void Run()
        {
            Console.WriteLine(nameof(MementoCase));

            var dummyObject = new DummyObject("first version");
            dummyObject.Move(10, 20);
            dummyObject.GetStatus();

            dummyObject.SaveState();

            dummyObject.Move(15, 25);
            dummyObject.Rename("second version");

            dummyObject.GetStatus();

            dummyObject.Restore();
            dummyObject.GetStatus();
        }
    }
}
