using Patterns.Mediator.Contracts;

namespace Patterns.Mediator.Impl
{
    internal class ConcreteColleagueB : Colleague
    {
        public ConcreteColleagueB(IMediator mediator)
            : base(mediator)
        {

        }

        public override void Receive(string message)
        {
            Console.WriteLine($"{nameof(ConcreteColleagueB)} received message: {message}");
        }

        public override void Send(string message)
        {
            Console.WriteLine($"{nameof(ConcreteColleagueB)} sended message: {message}");
            _mediator.SendMessage(message, this);
        }
    }
}
