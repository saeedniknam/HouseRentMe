namespace HouseRent.Core.Domain.Framework;

public abstract class BaseEntity<TId>(TId id)
{
    public TId Id { get; set; } = id;

    private readonly List<IDomainEvent> _events = [];

    protected void AddDomainEvent(IDomainEvent domainEvent)
    {
        _events.Add(domainEvent);
    }
    protected void ClearDomainEvent()
    {
        _events.Clear();
    }

    public IReadOnlyList<IDomainEvent> domainEvents => _events;
}
