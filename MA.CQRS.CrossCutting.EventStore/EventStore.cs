using MA.CQRS.Domain.Services;
using NetDevPack.Messaging;

namespace MA.CQRS.CrossCutting.EventStore
{
    public class EventStore : IEventStore
    {
        public ICollection<Event> events;

        public EventStore()
        {
            this.events = new List<Event>();
        }

        public void AddEvent(Event item)
        {
            events.Add(item);
        }

        public ICollection<Event> ObtainEvents()
        {
            return events;
        }
    }
}