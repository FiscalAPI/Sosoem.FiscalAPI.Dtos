using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sosoem.FiscalAPI.Dtos.Common;
/// <summary>
/// Base response
/// </summary>
/// <typeparam name="T"></typeparam>
public class ApiResponse<T>
{
    public T? Data { get; set; }
    public bool Succeeded { get; set; } = false;
    public string? Message { get; set; } = string.Empty;
    public string? Details { get; set; } = string.Empty;

    /// <summary>
    /// Used only for internal services as stripeService and pacService
    /// For api responses will be ignores by Json Serializer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public HttpStatusCode HttpStatusCode { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this, JsonSerializerOptions.Default);
    }
}