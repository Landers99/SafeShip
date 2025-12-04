using System;
using System.Text.Json.Nodes;

namespace SafeShip.API.Models;

public class TelemetryEvent
{
    public Guid Id { get; set; }
    public Guid ClientId { get; set; }
    public string EventType { get; set; }
    public DateTime Timestamp { get; set; }
    public string PayloadJson { get; set; }
}
