using ArtForAll.GenericsLinqCollections.Varianza.interfcaes;

namespace ArtForAll.GenericsLinqCollections.Varianza.Entities;
public abstract class AggregateRoot : Entity
{
    private List<IDomainEvent> domainEvents = new List<IDomainEvent>();
    public virtual IReadOnlyList<IDomainEvent> DomainEvents => domainEvents;

    protected virtual void AddDomainEvent(IDomainEvent eventItem)
    {
        domainEvents = domainEvents ?? new List<IDomainEvent>();
        domainEvents.Add(eventItem);
    }

    public virtual void RemoveDomainEvent()
    {
        domainEvents?.Clear();
    }
}
