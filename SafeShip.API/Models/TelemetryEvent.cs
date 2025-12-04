namespace SafeShip.API.Models;

public class TelemetryEvent
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid ClientId { get; set; }
    public string EventType { get; set; } = string.Empty;
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    public string PayloadJson { get; set; } = string.Empty;
}
