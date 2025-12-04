using SafeShip.API.Models;

namespace SafeShip.API.Repositories;

public interface IClientRepository
{
    Client Upsert(Client client);
    Client? GetById(Guid id);
    IEnumerable<Client> GetAll();
}
