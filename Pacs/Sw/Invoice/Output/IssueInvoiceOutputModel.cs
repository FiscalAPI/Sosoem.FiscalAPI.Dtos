using System.Text.Json.Serialization;

namespace Sosoem.FiscalAPI.Dtos.Pacs.Sw.Invoice.Output;

public class IssueInvoiceOutputModel
{
    [JsonPropertyName("cadenaOriginalSAT")]
    public string? TaOriginalString { get; set; } = string.Empty;

    [JsonPropertyName("noCertificadoSAT")] 
    public string? TaCertificateNumber { get; set; } = string.Empty;

    [JsonPropertyName("noCertificadoCFDI")]
    public string? InvoiceCertificateNumber { get; set; } = string.Empty;

    [JsonPropertyName("uuid")]
    public string? InvoiceUuid { get; set; } = string.Empty;

    [JsonPropertyName("selloSAT")]
    public string? TaSignatureValue { get; set; } = string.Empty;

    [JsonPropertyName("selloCFDI")]
    public string? InvoiceSignatureValue { get; set; } = string.Empty;

    [JsonPropertyName("fechaTimbrado")] 
    public string? InvoiceSignatureDate { get; set; } = string.Empty;

    [JsonPropertyName("qrCode")] 
    public string? InvoiceQrCode { get; set; } = string.Empty;

    [JsonPropertyName("cfdi")] 
    public string? InvoiceRawXml { get; set; } = string.Empty;
}