namespace Patterns.TemplateMethod.Contracts
{
    internal abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            Console.WriteLine($"{nameof(AbstractClass)}: Выполнение {nameof(Operation1)}");
            Operation1();

            Console.WriteLine($"{nameof(AbstractClass)}: Выполнение {nameof(Operation2)}");
            Operation2();

            Console.WriteLine($"{nameof(AbstractClass)}: Выполнение {nameof(Operation3)}");
            Operation3();

            Console.WriteLine($"{nameof(AbstractClass)}: Выполнение {nameof(Operation4)}");
            Operation4();

        }

        protected abstract void Operation1();
        protected abstract void Operation2();
        protected abstract void Operation3();
        protected abstract void Operation4();
    }
}
