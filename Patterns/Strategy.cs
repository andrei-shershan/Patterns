namespace Patterns.Patterns
{
    namespace Strategy
    {
        public interface IStrategy
        {
            void FindInformation();
        }

        public class WebBrowser : IStrategy
        {
            public void FindInformation()
            {
                Console.WriteLine("Some data retreived from Google");
            }
        }

        public class AiAgent : IStrategy
        {
            public void FindInformation()
            {
                Console.WriteLine("Some data retreived from AI");
            }
        }

        public class Context
        {
            private IStrategy _strategy;

            public Context()
            {
                
            }

            public void SetStrategy(IStrategy strategy)
            {
                _strategy = strategy;
            }

            public void DoSomething()
            {
                _strategy.FindInformation();
            }
        }
    }
}
