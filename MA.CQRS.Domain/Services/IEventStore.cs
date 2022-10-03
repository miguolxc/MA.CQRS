using MA.CQRS.Domain.Events.Model;
using NetDevPack.Messaging;

namespace MA.CQRS.Domain.Services
{
    public interface IEventStore
    {
        void AddEvent(Event @event);
        ICollection<Event> ObtainEvents();
    }
}
