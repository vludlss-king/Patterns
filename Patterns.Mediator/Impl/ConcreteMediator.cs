using Patterns.Mediator.Contracts;

namespace Patterns.Mediator.Impl
{
    internal class ConcreteMediator : IMediator
    {
        private List<Colleague> colleagues = new();

        public void AddColleague(Colleague colleague)
        {
            colleagues.Add(colleague);
        }

        public void SendMessage(string message, Colleague colleague)
        {
            colleagues.ForEach(colleague =>
            {
                if (colleague != null)
                    colleague.Receive(message);
            });
        }
    }
}
