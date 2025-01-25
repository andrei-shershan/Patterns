using Patterns.Patterns.Observer;

namespace Patterns.UseCases
{
    public class ObserverCase : IUseCase
    {
        public void Run()
        {
            Console.WriteLine(nameof(ObserverCase));

            var newsAggregator = new NewsAggregator();

            var newsChannel = new NewsChannel("News Channel");
            newsAggregator.Attach(newsChannel);

            var webNews = new WebNews("Web News");
            newsAggregator.Attach(webNews);

            newsAggregator.ReceiveNews("Will AI replace all developers?");

            newsAggregator.Detach(newsChannel);

            newsAggregator.ReceiveNews("Don't worry and enjoy!");
        }
    }
}
