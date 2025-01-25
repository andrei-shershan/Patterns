namespace Patterns.Patterns
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        object Handle(object request);
    }

    public abstract class Handler : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public virtual object Handle(object request)
        {
            if (_nextHandler != null)
            {
                return _nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }

        public class ValidationHandler : Handler
        {
            public override object Handle(object request)
            {
                if (request is string && !string.IsNullOrWhiteSpace(request.ToString()))
                {
                    Console.WriteLine($"{nameof(ValidationHandler)} :: Data is valid");
                    return base.Handle(request);
                }
                else
                {
                    return "Validation failed";
                }
            }
        }

        public class SaveDataHandler : Handler
        {
            public override object Handle(object request)
            {
                var saveDataResult = true; // Let's pretend that data was saved via service
                if (saveDataResult)
                {
                    Console.WriteLine($"{nameof(SaveDataHandler)} :: Data is saved");
                    return base.Handle(request);
                }
                else
                {
                    return "Data was not saved";
                }
            }
        }

        public class LogHandler : Handler
        {
            public override object Handle(object request)
            {
                Console.WriteLine($"{nameof(LogHandler)} :: Data was logged");

                return base.Handle(request);
            }
        }
    }
}
