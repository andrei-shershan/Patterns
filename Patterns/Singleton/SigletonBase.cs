namespace Patterns.Patterns.Singleton
{
    public abstract class SigletonBase
    {
        public int Counter { get; set; }

        public void IncrementCounter(int i)
        {
            Counter += i;
        }

        public void MultiplyCounter(int multiplier)
        {
            Counter *= multiplier;
        }
    }
}
