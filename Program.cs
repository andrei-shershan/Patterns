using Patterns.UseCases;

namespace Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var signletonCase = new SingletonCase();
            signletonCase.Run();
        }
    }
}
