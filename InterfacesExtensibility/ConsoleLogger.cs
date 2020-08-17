namespace InterfacesExtensibility
{
    public class ConsoleLogger : ILogger
    {
        public void InfoLogger(string message)
        {
            System.Console.WriteLine(message);
        }
        public void ErrorLogger(string message)
        {
            System.Console.WriteLine(message);
        }
    }
}