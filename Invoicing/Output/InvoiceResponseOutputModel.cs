namespace Sosoem.FiscalAPI.Dtos.Invoicing.Output;

public class InvoiceResponseOutputModel
{
    /// <summary>
    /// FiscalAPI invoice's Id
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// CadenaOriginalSAT
    /// </summary>
    public string? Base64TaOriginalString { get; set; } = string.Empty;

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
    public string? Base64TaSignatureValue { get; set; } = string.Empty;

    /// <summary>
    /// selloCFDI
    /// </summary>
    public string? Base64InvoiceSignatureValue { get; set; } = string.Empty;


    /// <summary>
    /// fechaTimbrado
    /// </summary>
    public DateTime InvoiceSignatureDate { get; set; }

    /// <summary>
    /// Qr Code
    /// </summary>
    public string? Base64InvoiceQrCode { get; set; } = string.Empty;

    /// <summary>
    /// Valid invoice in base 64
    /// </summary>
    public string? Base64Invoice { get; set; } = string.Empty;
}