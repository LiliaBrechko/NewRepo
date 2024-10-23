namespace CarStore.Domain.Models.Primitives;

public class Entity
{
    private readonly List<DomainEvent> _events = new();

    public IEnumerable<DomainEvent> Events => _events;

    protected void Raise(DomainEvent e) { _events.Add(e); }

    public void ClearDomainEvents()
    {
        _events.Clear();
    }
}
