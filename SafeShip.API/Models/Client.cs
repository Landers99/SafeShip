using System;

namespace SafeShip.API.Models;

public class Client
{
    public int Id { get; set; }
    public int AppId { get; set; }
    public int Version { get; set; }
    public string OS { get; set; }
    public DateTime RegisteredAt { get; set; }
    public DateTime LastSeenAt { get; set; }
}
