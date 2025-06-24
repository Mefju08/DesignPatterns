namespace DesignPatterns.Creationals.Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var logger = Logger.Instance;
            logger.Log("Everithing is working");
        }
    }
}
