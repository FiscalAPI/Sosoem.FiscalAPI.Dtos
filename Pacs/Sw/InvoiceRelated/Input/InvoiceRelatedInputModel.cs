using System.Text.Json.Serialization;

namespace Sosoem.FiscalAPI.Dtos.Pacs.Sw.InvoiceRelated.Input;

public class InvoiceRelatedInputModel
{
    [JsonPropertyName("uuid")] public string InvoiceUuid { get; set; } = string.Empty;


    [JsonPropertyName("password")] public string Password { get; set; } = string.Empty;

    [JsonPropertyName("rfc")] public string Tin { get; set; } = string.Empty;

    [JsonPropertyName("b64Cer")] public string Base64Certificate { get; set; } = string.Empty;
    [JsonPropertyName("b64Key")] public string Base64PrivateKey { get; set; } = string.Empty;
}