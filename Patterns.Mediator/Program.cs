using Patterns.Mediator.Impl;

namespace Patterns.Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator mediator = new ConcreteMediator();

            ConcreteColleagueA colleagueA = new ConcreteColleagueA(mediator);
            ConcreteColleagueB colleagueB = new ConcreteColleagueB(mediator);

            mediator.AddColleague(colleagueA);
            mediator.AddColleague(colleagueB);

            colleagueA.Send($"Hello from {nameof(ConcreteColleagueA)}");
            colleagueB.Send($"Hello from {nameof(ConcreteColleagueB)}");
        }
    }
}