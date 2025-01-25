namespace Patterns.Patterns
{
    namespace TemplateMethod
    {
        public class Data { }

        public abstract class DummyProcessor
        {
            public void Process()
            {
                var data = GetData();
                ProcessData(data);
                SendDataSomeWhere(data);
            }

            protected abstract Data GetData();

            protected abstract void ProcessData(Data data);

            protected abstract void SendDataSomeWhere(Data data);
        }

        public class DbProcessor : DummyProcessor
        {
            protected override Data GetData()
            {
                Console.WriteLine("Get data from DB");
                return new Data();
            }

            protected override void ProcessData(Data data)
            {
                Console.WriteLine("Data processsing");
            }

            protected override void SendDataSomeWhere(Data data)
            {
                Console.WriteLine("Send data to another type of DB");
            }
        }

        public class LocalProcessor : DummyProcessor
        {
            protected override Data GetData()
            {
                Console.WriteLine("Get data from local storage");
                return new Data();
            }

            protected override void ProcessData(Data data)
            {
                Console.WriteLine("Data processsing");
            }

            protected override void SendDataSomeWhere(Data data)
            {
                Console.WriteLine("Send data to another local storage");
            }
        }
    }
}
