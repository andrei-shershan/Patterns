using Patterns.Patterns;

namespace Patterns.UseCases
{
    public class ProxyCase : IUseCase
    {
        public void Run()
        {
            Console.WriteLine(nameof(ProxyCase));
            
            var proxy = new ProxyDataService();

            var task = Task.Run(async () =>
            {
                for (var i = 0; i < 5; i++)
                {
                    Console.WriteLine(proxy.GetData());
                    await Task.Delay(100);
                }
            });

            task.Wait();
        }
    }
}
