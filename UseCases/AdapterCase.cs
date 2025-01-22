using Patterns.Patterns;

namespace Patterns.UseCases
{
    public class AdapterCase : IUseCase
    {
        public void Run()
        {
            Console.WriteLine(nameof(AdapterCase));

            var legacyAdaptee = new LegacyAdaptee();
            var target = new TargetAdapter(legacyAdaptee);

            target.DoSmth();
        }
    }
}
