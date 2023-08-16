using System.Text.Json.Serialization;
using Sosoem.FiscalAPI.Dtos.Extensions;
using Sosoem.FiscalAPI.Dtos.Invoicing.Output;

namespace Sosoem.FiscalAPI.Dtos.Pacs.Sw.Invoice.Output;

public class InvoiceCanceledOutputModelSw
{
    /// <summary>
    /// Unique cancellation identifier
    /// </summary>
    [JsonPropertyName("acuse")]
    public string? CancellationAcknowledgement { get; set; }

    /// <summary>
    /// List of canceled invoice uuids. Or list of  invoice uuids in proccess to be canceled.
    /// </summary>
    [JsonPropertyName("uuid")]
    public Dictionary<string, string>? InvoiceUuids { get; set; }


   


  
}