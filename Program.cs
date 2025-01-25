using Patterns.UseCases;

namespace Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var unsafeSingletonCase = new UnsafeSingletonCase();
            unsafeSingletonCase.Run();

            var lazySingletonCase = new LazySingletonCase();
            lazySingletonCase.Run();

            var fabricMethodCase = new FabricMethodCase();
            fabricMethodCase.Run();

            var abstractFactoryCase = new AbstractFactoryCase();
            abstractFactoryCase.Run();
            
            var builderCase = new BuilderCase();
            builderCase.Run();

            var prototypeCase = new PrototypeCase();
            prototypeCase.Run();

            var adapterCase = new AdapterCase();
            adapterCase.Run();

            var bridgeCase = new BridgeCase();
            bridgeCase.Run();

            var compositeCase = new CompositeCase();
            compositeCase.Run();

            var decoratorCase = new DecoratorCase();
            decoratorCase.Run();

            var facadeCase = new FacadeCase();
            facadeCase.Run();

            var proxyCase = new ProxyCase();
            proxyCase.Run();

            var chainOfResponsobilityCase = new ChainOfResponsobilityCase();
            chainOfResponsobilityCase.Run();

            var commandCase = new CommandCase();
            commandCase.Run();

            var iteratorCase = new IteratorCase();
            iteratorCase.Run();

            var mediatorCase = new MediatorCase();
            mediatorCase.Run();

            var mementoCase = new MementoCase();
            mementoCase.Run();
        }
    }
}
