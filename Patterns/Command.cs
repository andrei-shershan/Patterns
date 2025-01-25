namespace Patterns.Patterns
{
    public interface ICommand
    {
        void Execute();
    }

    public class SimpleCommand : ICommand
    {
        private readonly string _payload = string.Empty;

        public SimpleCommand(string payload)
        {
            _payload = payload;
        }

        public void Execute()
        {
            Console.WriteLine($"SIMPLE command execution: {_payload}");
        }
    }

    public class ComplexCommand : ICommand
    {
        private readonly Receiver _receiver;
        private readonly string _a;
        private readonly string _b;

        public ComplexCommand(Receiver receiver, string a, string b)
        {
            _receiver = receiver;
            _a = a;
            _b = b;
        }

        public void Execute()
        {
            Console.WriteLine("COMPLEX command execution");
            _receiver.DoSomething(_a);
            _receiver.DoSomethingElse(_b);
        }
    }

    public class Receiver
    {
        public void DoSomething(string a)
        {
            Console.WriteLine($"Receiver: Doing something with {a}");
        }

        public void DoSomethingElse(string b)
        {
            Console.WriteLine($"Receiver: Doing something else with {b}");
        }
    }

    public class Invoker
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void DoSomething()
        {
            Console.WriteLine("Invoker");
            _command?.Execute();
        }
    }
}
