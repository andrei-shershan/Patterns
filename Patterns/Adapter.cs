namespace Patterns.Patterns
{
    public interface ITarget
    {
        void DoSmth();
    }

    public class LegacyAdaptee
    {
        public void LegacyJob()
        {
            Console.WriteLine("Some Legacy job here...");
        }
    }

    public class TargetAdapter : ITarget
    {
        private readonly LegacyAdaptee _adaptee;

        public TargetAdapter(LegacyAdaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public void DoSmth()
        {
            _adaptee.LegacyJob();
        }
    }
}
