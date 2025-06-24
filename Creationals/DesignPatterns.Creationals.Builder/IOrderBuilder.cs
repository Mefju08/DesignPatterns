using DesignPatterns.Creationals.Builder.Models;

namespace DesignPatterns.Creationals.Builder
{
    internal interface IOrderBuilder
    {
        OrderBuilder AddPaymentMethod(PaymentMethods paymentMethod);
        OrderBuilder AddProdut(Product produt);
        OrderBuilder AddShippingAddress(string shippingAddress);
        Order Build();
    }
}