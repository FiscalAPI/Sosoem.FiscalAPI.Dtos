using System.Text.Json.Serialization;

namespace Sosoem.FiscalAPI.Dtos.Pacs.Sw.InvoiceCancelation.Input;

public class InvoiceCancelInputModel
{
    [JsonPropertyName("uuid")]
    public string? InvoiceUuid { get; set; } = string.Empty;

    [JsonPropertyName("password")]
    public string? Password { get; set; } = string.Empty;

    [JsonPropertyName("rfc")]
    public string? Tin { get; set; } = string.Empty;

    [JsonPropertyName("motivo")]
    public string? CancellationReasonCode { get; set; } = string.Empty;

    [JsonPropertyName("b64Cer")]
    public string? Base64CerFile { get; set; } = string.Empty;

    [JsonPropertyName("b64Key")]
    public string? Base64KeyFile { get; set; } = string.Empty;

    [JsonPropertyName("folioSustitucion")]
    public string? ReplacementUuid { get; set; } = string.Empty;
}