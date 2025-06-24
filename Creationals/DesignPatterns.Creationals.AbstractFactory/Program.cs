using DesignPatterns.Creationals.AbstractFactory.Factories;

namespace DesignPatterns.Creationals.AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal amount = 832.99m;

            var paymentService1 = new PaymentService(new EuropePaymentFactory());
            paymentService1.Pay(amount);

            Console.WriteLine();

            var paymentService2 = new PaymentService(new UsaPaymentFactory());
            paymentService2.Pay(amount);
        }
    }
}
