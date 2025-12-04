using System;

namespace SafeShip.API.Models;

public class Client
{
    public Guid Id { get; set; }
    public string AppId { get; set; }
    public string Version { get; set; }
    public string OS { get; set; }
    public DateTime RegisteredAt { get; set; }
    public DateTime LastSeenAt { get; set; }
}
