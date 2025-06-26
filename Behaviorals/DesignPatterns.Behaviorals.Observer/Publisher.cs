using DesignPatterns.Behaviorals.Observer.Interfaces;

namespace DesignPatterns.Behaviorals.Observer
{
    internal sealed class Publisher
    {
        private IList<ISubscriber> _subscribers = new List<ISubscriber>();

        public void Subscribe(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }

        public void Notify(float temperature)
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update(temperature);
            }
        }
    }
}
