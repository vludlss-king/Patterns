using Patterns.TemplateMethod.Contracts;
using Patterns.TemplateMethod.Impl;

namespace Patterns.TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractClass template = new ConcreteClass();

            template.TemplateMethod();
            Console.ReadKey();
        }
    }
}