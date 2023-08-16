using System.Text.Json.Serialization;

namespace Sosoem.FiscalAPI.Dtos.Pacs.Sw.Invoice.Input;

public class InvoiceCancelInputModelSw
{
    /// <summary>
    /// Invoice uuid to be canceled.
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? InvoiceUuid { get; set; } = string.Empty;

    /// <summary>
    /// Private key password.
    /// </summary>
    [JsonPropertyName("password")]
    public string? Password { get; set; } = string.Empty;

    /// <summary>
    /// Issuer's Tax Identification Number.
    /// </summary>
    [JsonPropertyName("rfc")]
    public string? Tin { get; set; } = string.Empty;

    /// <summary>
    /// Cancellation reason code.
    /// 01 Errors in relation to
    /// 02 Unrelated errors
    /// 03 The operation was not performed
    /// 04 Nominative transaction, related to a global invoice
    /// </summary>
    [JsonPropertyName("motivo")]
    public string? CancellationReasonCode { get; set; } = string.Empty;

    /// <summary>
    /// Base64 issuer's certificate.
    /// </summary>
    [JsonPropertyName("b64Cer")]
    public string? Base64CerFile { get; set; } = string.Empty;

    /// <summary>
    /// Base64 issuer's private key.
    /// </summary>
    [JsonPropertyName("b64Key")]
    public string? Base64KeyFile { get; set; } = string.Empty;

    /// <summary>
    /// Invoice uuid that replaces the invoice being cancelled.
    /// </summary>
    [JsonPropertyName("folioSustitucion")]
    public string? ReplacementUuid { get; set; } = string.Empty;
}