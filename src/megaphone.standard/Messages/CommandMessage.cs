using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace Megaphone.Standard.Messages
{
    public class CommandMessage
    {
        [JsonPropertyName("id")]
        public string Id { get; init; } = Guid.NewGuid().ToString();
        [JsonPropertyName("action")]
        public string Name { get; init; } = string.Empty;
        [JsonPropertyName("created")]
        public DateTimeOffset Created { get; init; } = DateTimeOffset.UtcNow;
        [JsonPropertyName("parameters")]
        public Dictionary<string, string> Parameters { get; init; } = new Dictionary<string, string>();
        [JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; init; } = new Dictionary<string, string>();
    }
}