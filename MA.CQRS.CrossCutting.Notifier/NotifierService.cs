using MA.CQRS.Domain.Services;

namespace MA.CQRS.CrossCutting.Notifier
{
    public class NotifierService : INotifierService
    {
        public void Notifier(string message)
        {
            Console.WriteLine(message);
        }
    }
}