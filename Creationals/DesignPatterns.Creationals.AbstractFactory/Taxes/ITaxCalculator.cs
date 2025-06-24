namespace DesignPatterns.Creationals.AbstractFactory.Taxes
{
    internal interface ITaxCalculator
    {
        public decimal Calculate(decimal amount);
    }
}
