using DesignPatterns.Behaviorals.Mediator.Models;

namespace DesignPatterns.Behaviorals.Mediator.ControlTowers
{
    internal class AirTrafficControlTower : IAirTrafficControlTower
    {
        private IList<Aircraft> _aircrafts = new List<Aircraft>();
        public void SendMessage(Aircraft aircraft, string message, Guid to)
        {
            var receiver = _aircrafts.Single(x => x.Id == to);
            receiver.Received(message, aircraft.Name);
        }

        public void Register(Aircraft aircraft)
        {
            _aircrafts.Add(aircraft);
            aircraft.SetTower(this);
        }
    }
}
