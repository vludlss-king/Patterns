using Patterns.Strategy.Contracts;

namespace Patterns.Strategy.Impl
{
    internal class ConcreteStrategyB : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine($"Выполнение стратегии {nameof(ConcreteStrategyB)}");
        }
    }
}
