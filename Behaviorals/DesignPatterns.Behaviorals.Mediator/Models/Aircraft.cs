using DesignPatterns.Behaviorals.Mediator.ControlTowers;

namespace DesignPatterns.Behaviorals.Mediator.Models
{
    internal sealed class Aircraft
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }

        private IAirTrafficControlTower _tower;
        public Aircraft(string name)
        {
            Id = Guid.CreateVersion7();
            Name = name;
        }

        public void SetTower(IAirTrafficControlTower tower)
        {
            _tower = tower;

        }
        public void SendMessage(string message, Guid to)
        {
            Console.WriteLine($"[{Name} has sent]: {message}");
            _tower.SendMessage(this, message, to);

        }

        public void Received(string message, string from)
        {
            Console.WriteLine($"[{Name} received from {from}]: {message}");
        }
    }
}
