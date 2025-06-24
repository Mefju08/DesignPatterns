using DesignPatterns.Creationals.Factory.Abstractions;

namespace DesignPatterns.Creationals.Factory.Services
{
    internal class PushNotification : INotification
    {
        public void Send(Guid userId, string message)
        {
            Console.WriteLine($"Sending push to {userId}: {message}");
        }
    }
}
