namespace DesignPatterns.Creationals.AbstractFactory.Taxes
{
    internal sealed class EuropeTaxCalculator : ITaxCalculator
    {
        public decimal Calculate(decimal amount)
        {
            var taxAmmount = amount * 0.23m;
            Console.WriteLine($"Tax for Europe is: {taxAmmount}");
            return taxAmmount;
        }
    }
}
