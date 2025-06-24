using DesignPatterns.Creationals.AbstractFactory.Invoices;
using DesignPatterns.Creationals.AbstractFactory.Taxes;

namespace DesignPatterns.Creationals.AbstractFactory.Factories
{
    internal sealed class EuropePaymentFactory : IRegionPaymentFactory
    {
        public IInvoiceGenerator CreateInvoiceGenerator()
            => new EuropeInvoiceGenerator();

        public ITaxCalculator CreateTaxCalculator()
            => new EuropeTaxCalculator();
    }
}
