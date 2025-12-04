using SafeShip.API.Models;

namespace SafeShip.API.Repositories;

public interface ITelemetryRepository
{
    void Add(TelemetryEvent evt);
    IEnumerable<TelemetryEvent> GetRecent(int count = 100);
}
