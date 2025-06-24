using DesignPatterns.Creationals.Builder.Models;

namespace DesignPatterns.Creationals.Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IOrderBuilder builder = new OrderBuilder();
            var order = builder.AddProdut(
                new Product("Laptop", 999.99m))
                .AddProdut(new Product("Keyboard", 12.99m))
                .AddShippingAddress("Kraków, ul. Dąbrowskiego 14/41b")
                .AddPaymentMethod(PaymentMethods.CreditCard)
                .Build();

            order.ShowOrder();
        }
    }
}
