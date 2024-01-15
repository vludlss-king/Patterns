using Patterns.Strategy.Contracts;

namespace Patterns.Strategy.Impl
{
    internal class BlueLogWriter : ILogWriter
    {
        public void WriteLog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
        }
    }
}
