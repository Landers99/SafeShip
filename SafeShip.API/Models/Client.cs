namespace SafeShip.API.Models;

public class Client
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string AppId { get; set; } = string.Empty;
    public string Version { get; set; } = string.Empty;
    public string OS { get; set; } = string.Empty;
    public DateTime RegisteredAt { get; set; } = DateTime.UtcNow;
    public DateTime LastSeenAt { get; set; } = DateTime.UtcNow;
}
