using Patterns.Strategy.Enums;
using Patterns.Strategy.Impl;

namespace Patterns.Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Выберите тип логгирования 1 - красный, 2 - синий: ");

            var input = Console.ReadLine();
            var type = (LoggerType)Convert.ToInt32(input);

            var context = type switch
            {
                LoggerType.Red => new LoggerContext(new RedLogWriter()),
                LoggerType.Blue => new LoggerContext(new BlueLogWriter()),
                _ => throw new ArgumentException(nameof(type))
            };
            context.WriteLog("Выведен лог");

            Console.ReadKey();
        }
    }
}