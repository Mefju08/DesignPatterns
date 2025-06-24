using DesignPatterns.Creationals.Factory.Abstractions;
using DesignPatterns.Creationals.Factory.Models;
using DesignPatterns.Creationals.Factory.Services;

namespace DesignPatterns.Creationals.Factory
{
    internal static class NotificationFactory
    {
        public static INotification CreateNotification(NotificationTypes type)
        {
            return type switch
            {
                NotificationTypes.Email => new EmailNotification(),
                NotificationTypes.Sms => new SmsNotification(),
                NotificationTypes.Push => new PushNotification(),
                _ => throw new NotImplementedException(
                    $"Notification type: {type.ToString()} is not implemented")
            };
        }
    }
}
