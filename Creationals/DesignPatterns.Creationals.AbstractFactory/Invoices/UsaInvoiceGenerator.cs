namespace DesignPatterns.Creationals.AbstractFactory.Invoices
{
    internal sealed class UsaInvoiceGenerator : IInvoiceGenerator
    {
        public void Generate()
        {
            Console.WriteLine("Generating USA's style invoice");
        }
    }
}
