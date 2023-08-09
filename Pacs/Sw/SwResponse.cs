using System.Text.Json.Serialization;

namespace Sosoem.FiscalAPI.Dtos.Pacs.Sw;

public class SwResponse<T>
{
    [JsonPropertyName("data")] public T? Data { get; set; }
    [JsonPropertyName("status")] public string Status { get; set; } = string.Empty;
    [JsonPropertyName("message")] public string Message { get; set; } = string.Empty;
    [JsonPropertyName("messageDetail")] public string MessageDetail { get; set; } = string.Empty;
}