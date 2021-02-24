using System.Text.Json.Serialization;

namespace Megaphone.Standard.Representations
{
    public class ErrorRepresentation : Representation
    {
        [JsonPropertyName("code")]
        public string Code { get; set; } = string.Empty;
        [JsonPropertyName("message")]
        public string Message { get; set; } = string.Empty;
        [JsonPropertyName("details")]
        public string Details { get; set; } = string.Empty;
    }
}