using DesignPatterns.Creationals.Builder.Models;

namespace DesignPatterns.Creationals.Builder
{
    internal sealed class OrderBuilder : IOrderBuilder
    {
        private Order _order;

        public OrderBuilder()
        {
            _order = new Order();
        }

        public OrderBuilder AddProdut(Product produt)
        {
            _order.Products.Add(produt);
            return this;
        }

        public OrderBuilder AddPaymentMethod(PaymentMethods paymentMethod)
        {
            _order.PaymentMethod = paymentMethod;
            return this;
        }

        public OrderBuilder AddShippingAddress(string shippingAddress)
        {
            _order.ShippingAddress = shippingAddress;
            return this;
        }

        public Order Build() => _order;
    }
}
