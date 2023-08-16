namespace Sosoem.FiscalAPI.Dtos.Invoicing.Output;

public class InvoiceSignedOutputModel
{
    /// <summary>
    /// CadenaOriginalSAT
    /// </summary>
    public string? TaOriginalString { get; set; } = string.Empty;

    /// <summary>
    /// noCertificadoSAT
    /// </summary>
    public string? TaCertificateNumber { get; set; } = string.Empty;

    /// <summary>
    /// noCertificadoCFDI
    /// </summary>
    public string? InvoiceCertificateNumber { get; set; } = string.Empty;

    /// <summary>
    /// uuid
    /// </summary>
    public string? InvoiceUuid { get; set; } = string.Empty;

    /// <summary>
    /// selloSAT
    /// </summary>
    public string? TaSignatureValue { get; set; } = string.Empty;

    /// <summary>
    /// selloCFDI
    /// </summary>
    public string? InvoiceSignatureValue { get; set; } = string.Empty;

    /// <summary>
    /// fechaTimbrado
    /// </summary>
    public string? InvoiceSignatureDate { get; set; } = string.Empty;

    /// <summary>
    /// Qr Code
    /// </summary>
    public string? InvoiceQrCode { get; set; } = string.Empty;

    /// <summary>
    /// Valid invoice in base 64
    /// </summary>
    public string? InvoiceBase64 { get; set; } = string.Empty;
}