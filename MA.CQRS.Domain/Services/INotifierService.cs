namespace MA.CQRS.Domain.Services
{
    public interface INotifierService
    {
        void Notifier(string message);
    }
}
