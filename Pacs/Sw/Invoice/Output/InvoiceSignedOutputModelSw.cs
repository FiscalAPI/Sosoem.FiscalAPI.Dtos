using System.Text.Json.Serialization;
using Sosoem.FiscalAPI.Dtos.Extensions;
using Sosoem.FiscalAPI.Dtos.Invoicing.Output;

namespace Sosoem.FiscalAPI.Dtos.Pacs.Sw.Invoice.Output;

public class InvoiceSignedOutputModelSw
{
    /// <summary>
    /// CadenaOriginalSAT
    /// </summary>
    [JsonPropertyName("cadenaOriginalSAT")]
    public string? TaOriginalString { get; set; } = string.Empty;

    /// <summary>
    /// noCertificadoSAT
    /// </summary>
    [JsonPropertyName("noCertificadoSAT")]
    public string? TaCertificateNumber { get; set; } = string.Empty;

    /// <summary>
    /// noCertificadoCFDI
    /// </summary>
    [JsonPropertyName("noCertificadoCFDI")]
    public string? InvoiceCertificateNumber { get; set; } = string.Empty;

    /// <summary>
    /// uuid
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? InvoiceUuid { get; set; } = string.Empty;

    /// <summary>
    /// selloSAT
    /// </summary>
    [JsonPropertyName("selloSAT")]
    public string? TaSignatureValue { get; set; } = string.Empty;

    /// <summary>
    /// selloCFDI
    /// </summary>
    [JsonPropertyName("selloCFDI")]
    public string? InvoiceSignatureValue { get; set; } = string.Empty;

    /// <summary>
    /// fechaTimbrado
    /// </summary>
    [JsonPropertyName("fechaTimbrado")]
    public string? InvoiceSignatureDate { get; set; } = string.Empty;

    /// <summary>
    /// Qr Code
    /// </summary>
    [JsonPropertyName("qrCode")]
    public string? InvoiceQrCode { get; set; } = string.Empty;

    /// <summary>
    /// Valid invoice in base 64
    /// </summary>
    [JsonPropertyName("cfdi")]
    public string? InvoiceRawXml { get; set; } = string.Empty;


    public InvoiceSignedOutputModel ToOutputModel()
    {
        return new InvoiceSignedOutputModel
        {
            TaOriginalString = TaOriginalString,
            TaCertificateNumber = TaCertificateNumber,
            InvoiceCertificateNumber = InvoiceCertificateNumber,
            InvoiceUuid = InvoiceUuid,
            TaSignatureValue = TaSignatureValue,
            InvoiceSignatureValue = InvoiceSignatureValue,
            InvoiceSignatureDate = InvoiceSignatureDate,
            InvoiceQrCode = InvoiceQrCode,
            InvoiceBase64 = InvoiceRawXml?.EncodeToBase64()
        };
    }
}