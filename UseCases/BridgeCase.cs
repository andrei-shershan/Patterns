using Patterns.Patterns;

namespace Patterns.UseCases
{
    public class BridgeCase : IUseCase
    {
        public void Run()
        {
            Console.WriteLine(nameof(BridgeCase));

            var emailMessage = new EmailMessage();
            var smsMessage = new SmsMessage();

            var reminderNotification = new ReminderNotification(emailMessage);
            reminderNotification.Notify();

            reminderNotification = new ReminderNotification(smsMessage);
            reminderNotification.Notify();

            var alertNotification = new AlertNotification(emailMessage);
            alertNotification.Notify();

            alertNotification = new AlertNotification(smsMessage);
            alertNotification.Notify();
        }
    }
}
