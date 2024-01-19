using Patterns.Strategy.Contracts;
using Patterns.Strategy.Impl;

namespace Patterns.Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IStrategy strategyA = new ConcreteStrategyA();
            IStrategy strategyB = new ConcreteStrategyB();
            IStrategy strategyC = new ConcreteStrategyC();

            Context contextA = new Context(strategyA);
            Context contextB = new Context(strategyB);
            Context contextC = new Context(strategyC);

            contextA.ExecuteStrategy();
            contextB.ExecuteStrategy();
            contextC.ExecuteStrategy();
        }
    }
}