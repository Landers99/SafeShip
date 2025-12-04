using System;
using System.Text.Json.Nodes;

namespace SafeShip.API.Models;

public class TelemetryEvent
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public string EventType { get; set; }
    public DateTime Timestamp { get; set; }
    public JsonObject PayloadJson { get; set; }
}
