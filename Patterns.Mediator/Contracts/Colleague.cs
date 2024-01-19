namespace Patterns.Mediator.Contracts
{
    internal abstract class Colleague
    {
        protected IMediator _mediator;

        public Colleague(IMediator mediator)
        {
            _mediator = mediator;
        }

        public abstract void Receive(string message);
        public abstract void Send(string message);
    }
}
