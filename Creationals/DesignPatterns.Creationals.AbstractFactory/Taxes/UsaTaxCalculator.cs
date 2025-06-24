namespace DesignPatterns.Creationals.AbstractFactory.Taxes
{
    internal sealed class UsaTaxCalculator : ITaxCalculator
    {
        public decimal Calculate(decimal amount)
        {
            var taxAmmount = amount * 0.07m;
            Console.WriteLine($"Tax for USA is: {taxAmmount}");
            return taxAmmount;
        }
    }
}
