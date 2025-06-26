using DesignPatterns.Behaviorals.Strategy.Payments;

namespace DesignPatterns.Behaviorals.Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const decimal amount = 100m;

            var payment = new Payment(new CashPaymentStrategy());
            payment.Pay(amount);

            payment.SetStrategy(new CardPaymentStrategy());
            payment.Pay(amount);
        }
    }
}
