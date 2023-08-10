using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sosoem.FiscalAPI.Dtos.Pacs.Sw.InvoiceRelated.Output;

public class InvoiceRelatedOutputModel
{
    //public string codStatus { get; set; }

    [JsonPropertyName("uuidConsultado")] public string SearchedUuid { get; set; } = string.Empty;

    [JsonPropertyName("resultado")] public string MessageResult { get; set; } = string.Empty;

    [JsonPropertyName("uuidsRelacionadosPadres")]
    public List<ParentInvoice> ParentInvoices { get; set; } = new();

    [JsonPropertyName("uuidsRelacionadosHijos")]
    public List<ChildInvoice> ChildInvoices { get; set; } = new();
}

public class ParentInvoice
{
    [JsonPropertyName("uuidsRelacionadosPadres")]
    public List<ParentInvoice> ParentInvoices { get; set; } = new();

    [JsonPropertyName("uuid")] public string Uuid { get; set; } = string.Empty;

    [JsonPropertyName("rfcEmisor")] public string IssuerTin { get; set; } = string.Empty;

    [JsonPropertyName("rfcReceptor")] public string RecipientTin { get; set; } = string.Empty;
}

public class ChildInvoice
{
    [JsonPropertyName("uuid")] public string Uuid { get; set; } = string.Empty;

    [JsonPropertyName("rfcEmisor")] public string IssuerTin { get; set; } = string.Empty;

    [JsonPropertyName("rfcReceptor")] public string RecipientTin { get; set; } = string.Empty;
}

