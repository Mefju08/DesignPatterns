using DesignPatterns.Creationals.AbstractFactory.Factories;

namespace DesignPatterns.Creationals.AbstractFactory
{
    internal sealed class PaymentService
    {
        private readonly IRegionPaymentFactory _factory;
        public PaymentService(IRegionPaymentFactory factory)
        {
            _factory = factory;
        }

        public void Pay(decimal amount)
        {
            var taxCalculator = _factory.CreateTaxCalculator();
            var tax = taxCalculator.Calculate(amount);

            var invoiceGenerator = _factory.CreateInvoiceGenerator();
            invoiceGenerator.Generate();
        }
    }
}
