namespace Patterns.UseCases
{
    internal interface IUseCase
    {
        void Run();
    }

    internal abstract class UseCaseCreator
    {
        public abstract IUseCase Create();

        public void CreateCase()
        {
            var useCase = Create();
            useCase.Run();
        }
    }
}
