using DesignPatterns.Behaviorals.Mediator.Models;

namespace DesignPatterns.Behaviorals.Mediator.ControlTowers
{
    internal interface IAirTrafficControlTower
    {
        void Register(Aircraft aircraft);
        void SendMessage(Aircraft aircraft, string message, Guid to);
    }
}
