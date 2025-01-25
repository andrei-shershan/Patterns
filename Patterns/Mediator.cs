namespace Patterns.Patterns
{
    namespace Mediator
    {
        public interface IMediator
        {
            void SendMessageToMembers(object sender, string message);
        }

        public class ConcreteMediatore : IMediator
        {
            private readonly ICollection<BaseUser> _members = new List<BaseUser>();

            public void AddMember(BaseUser member)
            {
                _members.Add(member);
                member._mediator = this;
            }

            public void SendMessageToMembers(object sender, string message)
            {
                Console.WriteLine($"Message from {sender} to members: {message}");
                foreach(var member in _members)
                {
                    if (member != sender)
                    {
                        member.Receive(message);
                    }
                }
            }
        }

        public abstract class BaseUser
        {
            protected string _name;

            public IMediator _mediator;

            public BaseUser(string name)
            {
                _name = name;
            }

            public abstract void Send(string message);
            public abstract void Receive(string message);
        }

        public class ConcreteUser : BaseUser
        {
            public ConcreteUser(string name) : base(name)
            {
            }

            public override void Receive(string message)
            {
                Console.WriteLine($"{_name} received message: {message}");
            }

            public override void Send(string message)
            {
                Console.WriteLine($"{_name} sendind message: {message}");
                _mediator?.SendMessageToMembers(this, message);
            }
        }
    }
}
