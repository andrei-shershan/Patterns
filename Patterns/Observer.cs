namespace Patterns.Patterns
{
    namespace Observer
    {
        public interface IObserver
        {
            void Update(string message);
        }

        public interface ISubject
        {
            void Attach(IObserver observer);
            void Detach(IObserver observer);
        }

        public class NewsAggregator : ISubject
        {
            private readonly List<IObserver> _observers = new List<IObserver>();

            private string _lastNews;

            public void Attach(IObserver observer)
            {
                _observers.Add(observer);
            }

            public void Detach(IObserver observer)
            {
                _observers.Remove(observer);
            }

            public void ReceiveNews(string news)
            {
                _lastNews = news;
                Notify();
            }

            private void Notify()
            {
                foreach (var observer in _observers)
                {
                    observer.Update(_lastNews);
                }
            }
        }

        public class NewsChannel : IObserver
        {
            private readonly string _name;

            public NewsChannel(string name)
            {
                _name = name;
            }

            public void Update(string message)
            {
                Console.WriteLine($"{_name} received news: {message}");
            }
        }

        public class WebNews : IObserver
        {
            private readonly string _url;

            public WebNews(string url)
            {
                _url = url;
            }

            public void Update(string message)
            {
                var trimmedMessage = message.Length > 15 ? message.Substring(0, 15) : message;
                Console.WriteLine($"{_url} received news: {trimmedMessage}... Subscribe to get details!");
            }
        }
    }
}
