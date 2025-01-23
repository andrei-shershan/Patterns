namespace Patterns.Patterns
{
    public class SubsystemA
    {
        public void OperationA()
        {
            System.Console.WriteLine("SubsystemA.OperationA");
        }
    }

    public class SubsystemB
    {
        public void OperationB()
        {
            System.Console.WriteLine("SubsystemB.OperationB");
        }
    }

    public class Facade
    {
        private SubsystemA _subsystemA;
        private SubsystemB _subsystemB;

        public Facade(SubsystemA subsystemA, SubsystemB subsystemB)
        {
            _subsystemA = subsystemA;
            _subsystemB = subsystemB;
        }

        public void Operation()
        {
            _subsystemA.OperationA();
            _subsystemB.OperationB();
        }
    }
}


