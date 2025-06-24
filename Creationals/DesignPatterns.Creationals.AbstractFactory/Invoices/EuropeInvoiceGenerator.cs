namespace DesignPatterns.Creationals.AbstractFactory.Invoices
{
    internal sealed class EuropeInvoiceGenerator : IInvoiceGenerator
    {
        public void Generate()
        {
            Console.WriteLine("Generating Europe's style invoice");
        }
    }
}
