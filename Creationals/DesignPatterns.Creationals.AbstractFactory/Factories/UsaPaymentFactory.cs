using DesignPatterns.Creationals.AbstractFactory.Invoices;
using DesignPatterns.Creationals.AbstractFactory.Taxes;

namespace DesignPatterns.Creationals.AbstractFactory.Factories
{
    internal sealed class UsaPaymentFactory : IRegionPaymentFactory
    {
        public IInvoiceGenerator CreateInvoiceGenerator()
            => new UsaInvoiceGenerator();

        public ITaxCalculator CreateTaxCalculator()
            => new UsaTaxCalculator();
    }
}
