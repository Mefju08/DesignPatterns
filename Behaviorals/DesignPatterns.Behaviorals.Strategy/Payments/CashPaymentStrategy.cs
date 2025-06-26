using DesignPatterns.Behaviorals.Strategy.Intrefaces;

namespace DesignPatterns.Behaviorals.Strategy.Payments
{
    internal sealed class CashPaymentStrategy : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paying {amount} with cash");
        }
    }
}
