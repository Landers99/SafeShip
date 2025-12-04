using System.ComponentModel;
using SafeShip.API.Models;

namespace SafeShip.API.Repositories;

public class InMemoryFeatureFlagRepository : IFeatureFlagRepository
{
    private readonly List<FeatureFlag> _flags = new()
    {
        new FeatureFlag
        {
            Name = "FeatureNewUI",
            Description = "Example feature flag for new UI",
            IsEnabled = true
        },
        new FeatureFlag
        {
            Name = "FeatureBetaThing",
            Description = "Example beta feature",
            IsEnabled = false
        }
    };
    public IEnumerable<FeatureFlag> GetAll() => _flags;
    public FeatureFlag? GetByName(string name) =>
        _flags.FirstOrDefault(f => f.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
}
