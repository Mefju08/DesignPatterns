namespace DesignPatterns.Creationals.Singleton
{
    internal sealed class Logger
    {
        private static readonly Lazy<Logger> _instance = new(() => new Logger());
        private Logger() { }

        public static Logger Instance => _instance.Value;

        public void Log(string message)
        {
            Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {message}");
        }
    }
}
