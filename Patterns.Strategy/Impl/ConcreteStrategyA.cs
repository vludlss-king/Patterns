using Patterns.Strategy.Contracts;

namespace Patterns.Strategy.Impl
{
    internal class ConcreteStrategyA : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine($"Выполнение стратегии {nameof(ConcreteStrategyA)}");
        }
    }
}
