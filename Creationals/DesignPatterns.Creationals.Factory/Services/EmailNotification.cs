using DesignPatterns.Creationals.Factory.Abstractions;

namespace DesignPatterns.Creationals.Factory.Services
{
    internal class EmailNotification : INotification
    {
        public void Send(Guid userId, string message)
        {
            Console.WriteLine($"Sending e-mail to {userId}: {message}");
        }
    }
}
