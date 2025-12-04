using SafeShip.API.Models;

namespace SafeShip.API.Repositories;

public class InMemoryClientRepository : IClientRepository
{
    private readonly List<Client> _clients = new();

    public Client Upsert(Client client)
    {
        var existing = _clients.FirstOrDefault(c => c.Id == client.Id);

        if (existing is null)
        {
            _clients.Add(client);
            return client;
        }

        existing.AppId = client.AppId;
        existing.Version = client.Version;
        existing.OS = client.OS;
        existing.LastSeenAt = client.LastSeenAt;
        return existing;
    }

    public Client? GetById(Guid id) => _clients.FirstOrDefault(c => c.Id == id);
    public IEnumerable<Client> GetAll() => _clients;
}
