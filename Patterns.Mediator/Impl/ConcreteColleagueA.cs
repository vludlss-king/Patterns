using Patterns.Mediator.Contracts;

namespace Patterns.Mediator.Impl
{
    internal class ConcreteColleagueA : Colleague
    {
        public ConcreteColleagueA(IMediator mediator)
            : base(mediator)
        {
            
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"{nameof(ConcreteColleagueA)} received message: {message}");
        }

        public override void Send(string message)
        {
            Console.WriteLine($"{nameof(ConcreteColleagueA)} sended message: {message}");
            _mediator.SendMessage(message, this);
        }
    }
}
