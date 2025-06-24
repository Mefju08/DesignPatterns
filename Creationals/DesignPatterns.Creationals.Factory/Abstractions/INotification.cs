namespace DesignPatterns.Creationals.Factory.Abstractions
{
    internal interface INotification
    {
        public void Send(Guid userId, string message);
    }
}
