using DesignPatterns.Creationals.AbstractFactory.Invoices;
using DesignPatterns.Creationals.AbstractFactory.Taxes;

namespace DesignPatterns.Creationals.AbstractFactory.Factories
{
    internal interface IRegionPaymentFactory
    {
        IInvoiceGenerator CreateInvoiceGenerator();
        ITaxCalculator CreateTaxCalculator();
    }
}
