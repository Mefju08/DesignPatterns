namespace DesignPatterns.Creationals.Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userId = Guid.NewGuid();
            const string message = "Your file is ready to download";

            var notification1 = NotificationFactory.CreateNotification(Models.NotificationTypes.Email);
            notification1.Send(userId, message);

            var notification2 = NotificationFactory.CreateNotification(Models.NotificationTypes.Sms);
            notification2.Send(userId, message);

            var notification3 = NotificationFactory.CreateNotification(Models.NotificationTypes.Push);
            notification3.Send(userId, message);
        }
    }
}
