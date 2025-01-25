using Patterns.Patterns.Mediator;

namespace Patterns.UseCases
{
    public class MediatorCase : IUseCase
    {
        public void Run()
        {
            Console.WriteLine(nameof(MediatorCase));

            var userA = new ConcreteUser("User A");
            var userB = new ConcreteUser("User B");
            var userC = new ConcreteUser("User C");
            var userD = new ConcreteUser("User D");

            var mediator = new ConcreteMediatore();

            mediator.AddMember(userA);
            mediator.AddMember(userC);
            mediator.AddMember(userD);

            userA.Send("Hello, User C!");
        }
    }
}
