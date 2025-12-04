using System;

namespace SafeShip.API.Models;

public class FeatureFlag
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsEnabled { get; set; }
}
