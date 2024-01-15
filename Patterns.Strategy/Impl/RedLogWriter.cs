using Patterns.Strategy.Contracts;

namespace Patterns.Strategy.Impl
{
    internal class RedLogWriter : ILogWriter
    {
        public void WriteLog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }
    }
}
