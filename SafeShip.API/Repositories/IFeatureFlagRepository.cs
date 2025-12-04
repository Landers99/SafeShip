using SafeShip.API.Models;

namespace SafeShip.API.Repositories;

public interface IFeatureFlagRepository
{
    IEnumerable<FeatureFlag> GetAll();
    FeatureFlag? GetByName(string name);
}
