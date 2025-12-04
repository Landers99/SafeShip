using SafeShip.API.Models;

namespace SafeShip.API.Repositories;

public class InMemoryTelemetryRepository : ITelemetryRepository
{
    private readonly List<TelemetryEvent> _events = new();
    public void Add(TelemetryEvent evt)
    {
        _events.Add(evt);
    }
    public IEnumerable<TelemetryEvent> GetRecent(int count = 100) =>
        _events.OrderByDescending(e => e.Timestamp).Take(count);
}
