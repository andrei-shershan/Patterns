namespace Patterns.Patterns
{
    public class Director
    {
        private IVechicleBuilder _builder;

        public Director(IVechicleBuilder builder)
        {
            _builder = builder;
        }

        public void Construct()
        {
            _builder.BuildEngine();
            _builder.BuildWheels();
        }
    }

    public class Vechicle
    {
        public string? Engine { get; set; }

        public string? Wheels { get; set; }

        public void PrintSpecification()
        {
            Console.WriteLine($"Engine is: {Engine}, Wheels are: {Wheels}");
        }
    }

    public interface IVechicleBuilder
    {
        public void BuildEngine();

        public void BuildWheels();
    }


    public abstract class BaseVechileBuilder
    {
        protected readonly Vechicle _vechicle = new Vechicle();

        public Vechicle Vechicle => _vechicle;
    }

    public class FossileFurelCarBuilder : BaseVechileBuilder, IVechicleBuilder
    {
        public void BuildEngine()
        {
            _vechicle.Engine = "Oil engine";
        }

        public void BuildWheels()
        {
            _vechicle.Wheels = "4 wheels";
        }
    }

    public class FutureFlyingCar : BaseVechileBuilder, IVechicleBuilder
    {
        public void BuildEngine()
        {
            _vechicle.Engine = "Nuclear engine";
        }

        public void BuildWheels()
        {
            _vechicle.Wheels = "Magnetic tray";
        }
    }
}
