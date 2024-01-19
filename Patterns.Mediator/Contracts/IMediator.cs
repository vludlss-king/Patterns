namespace Patterns.Mediator.Contracts
{
    internal interface IMediator
    {
        void SendMessage(string message, Colleague colleague);
    }
}
