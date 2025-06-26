using DesignPatterns.Behaviorals.Observer.Interfaces;

namespace DesignPatterns.Behaviorals.Observer
{
    internal sealed class Subscriber : ISubscriber
    {
        private readonly string _name;
        public Subscriber(string name)
        {
            _name = name;
        }
        public void Update(float temperature)
        {
            Console.WriteLine($"Subscriber: {_name} has been notified about new temperature: {temperature}");
        }
    }
}
