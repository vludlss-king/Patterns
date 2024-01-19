using Patterns.TemplateMethod.Contracts;

namespace Patterns.TemplateMethod.Impl
{
    internal class ConcreteClass : AbstractClass
    {
        protected override void Operation1()
        {
            Console.WriteLine($"{nameof(ConcreteClass)}: Реализация операции {nameof(Operation1)}");
        }

        protected override void Operation2()
        {
            Console.WriteLine($"{nameof(ConcreteClass)}: Реализация операции {nameof(Operation2)}");
        }

        protected override void Operation3()
        {
            Console.WriteLine($"{nameof(ConcreteClass)}: Реализация операции {nameof(Operation3)}");
        }

        protected override void Operation4()
        {
            Console.WriteLine($"{nameof(ConcreteClass)}: Реализация операции {nameof(Operation4)}");
        }
    }
}
