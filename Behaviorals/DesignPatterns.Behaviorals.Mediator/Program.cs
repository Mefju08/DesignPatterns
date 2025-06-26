
using DesignPatterns.Behaviorals.Mediator.ControlTowers;
using DesignPatterns.Behaviorals.Mediator.Models;

namespace DesignPatterns.Behaviorals.Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tower = new AirTrafficControlTower();

            var aircraft1 = new Aircraft("Airbus");
            var aircraft2 = new Aircraft("Boeing");

            tower.Register(aircraft1);
            tower.Register(aircraft2);

            aircraft1.SendMessage("Im landing", aircraft2.Id);
        }
    }
}
