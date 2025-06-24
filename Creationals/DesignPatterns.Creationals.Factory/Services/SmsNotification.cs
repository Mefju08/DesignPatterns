using DesignPatterns.Creationals.Factory.Abstractions;

namespace DesignPatterns.Creationals.Factory.Services
{
    internal sealed class SmsNotification : INotification
    {
        public void Send(Guid userId, string message)
        {
            Console.WriteLine($"Sending sms to {userId}: {message}");
        }
    }
}
