using System.Text.Json.Serialization;

namespace Sosoem.FiscalAPI.Dtos.Pacs.Sw.InvoiceCancelation.Output;

public class InvoiceCancelOutputModel
{
    [JsonPropertyName("acuse")]
    public string? CancellationAcknowledgement { get; set; }

    [JsonPropertyName("uuid")]
    public Dictionary<string, string>? InvoiceUuids { get; set; }
}