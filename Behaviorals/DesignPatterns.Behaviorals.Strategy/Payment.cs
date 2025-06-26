using DesignPatterns.Behaviorals.Strategy.Intrefaces;

namespace DesignPatterns.Behaviorals.Strategy
{
    internal sealed class Payment
    {
        private IPaymentStrategy _strategy;
        public Payment(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Pay(decimal amount)
        {
            _strategy.Pay(amount);
        }
    }
}
