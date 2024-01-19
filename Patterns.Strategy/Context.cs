﻿using Patterns.Strategy.Contracts;

namespace Patterns.Strategy
{
    internal class Context
    {
        private readonly IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ExecuteStrategy()
        {
            _strategy.Execute();
        }
    }
}
