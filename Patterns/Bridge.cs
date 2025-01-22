namespace Patterns.Patterns
{
    public interface IMessager
    {
        void SendMessage();
    }

    public class EmailMessager : IMessager
    {
        public void SendMessage()
        {
            System.Console.WriteLine("Email message sent");
        }
    }

    public class SmsMessager : IMessager
    {
        public void SendMessage()
        {
            System.Console.WriteLine("SMS message sent");
        }
    }

    public abstract class Notification
    {
        protected IMessager _messageger;

        public Notification(IMessager messageger)
        {
            _messageger = messageger;
        }

        public abstract void Notify();
    }

    public class ReminderNotification : Notification
    {
        public ReminderNotification(IMessager messageger) : base(messageger)
        {
        }

        public override void Notify()
        {
            Console.WriteLine("REMINDER");
            _messageger.SendMessage();
        }
    }

    public class AlertNotification : Notification
    {
        public AlertNotification(IMessager messageger) : base(messageger)
        {
        }

        public override void Notify()
        {
            Console.WriteLine("ALERT");
            _messageger.SendMessage();
        }
    }
}
