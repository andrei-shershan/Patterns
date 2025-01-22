namespace Patterns.Patterns
{
    public interface IMessageger
    {
        void SendMessage();
    }

    public class EmailMessage : IMessageger
    {
        public void SendMessage()
        {
            System.Console.WriteLine("Email message sent");
        }
    }

    public class SmsMessage : IMessageger
    {
        public void SendMessage()
        {
            System.Console.WriteLine("SMS message sent");
        }
    }

    public abstract class Notification
    {
        protected IMessageger _messageger;

        public Notification(IMessageger messageger)
        {
            _messageger = messageger;
        }

        public abstract void Notify();
    }

    public class ReminderNotification : Notification
    {
        public ReminderNotification(IMessageger messageger) : base(messageger)
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
        public AlertNotification(IMessageger messageger) : base(messageger)
        {
        }

        public override void Notify()
        {
            Console.WriteLine("ALERT");
            _messageger.SendMessage();
        }
    }
}
