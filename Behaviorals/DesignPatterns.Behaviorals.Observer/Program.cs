namespace DesignPatterns.Behaviorals.Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var subscriber1 = new Subscriber("Albert");
            var subscriber2 = new Subscriber("Thomas");

            var publisher = new Publisher();
            publisher.Subscribe(subscriber1);
            publisher.Subscribe(subscriber2);

            publisher.Notify(21);

            publisher.Unsubscribe(subscriber1);

            publisher.Notify(10);
        }
    }
}
