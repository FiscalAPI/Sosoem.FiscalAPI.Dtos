using System.Text.Json.Serialization;

namespace Sosoem.FiscalAPI.Dtos.Pacs.Sw.InvoiceValidation.Output;

public class InvoiceValidationOutputModel
{
    [JsonPropertyName("status")] 
    public string? Status { get; set; }


    [JsonPropertyName("cadenaOriginalSAT")]
    public string? TaOriginalString { get; set; }

    [JsonPropertyName("cadenaOriginalComprobante")]
    public string? InvoiceOriginalString { get; set; }

    [JsonPropertyName("uuid")] public string? Uuid { get; set; }

    [JsonPropertyName("statusSat")] public string? StatusSat { get; set; }

    [JsonPropertyName("statusCodeSat")] public string? StatusCodeSat { get; set; }


    [JsonPropertyName("isCancelable")] public string? IsCancelable { get; set; }

    [JsonPropertyName("statusCancelation")]
    public string? CancelationStatus { get; set; }


    [JsonPropertyName("detail")] public List<Error> Errors { get; set; } = new();
}

public class Error
{
    [JsonPropertyName("detail")] public List<ErrorDetail> Errors { get; set; } = new();
    [JsonPropertyName("section")] public string? ErrorSection { get; set; }
}

public class ErrorDetail
{
    [JsonPropertyName("message")] public string? Message { get; set; }
    [JsonPropertyName("messageDetail")] public string? MessageDetail { get; set; }
    [JsonPropertyName("type")] public int Type { get; set; }
    [JsonPropertyName("typeValue")] public string? TypeValue { get; set; }
}