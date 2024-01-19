using Patterns.Strategy.Contracts;

namespace Patterns.Strategy.Impl
{
    internal class ConcreteStrategyC : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine($"Выполнение стратегии {nameof(ConcreteStrategyC)}");
        }
    }
}
