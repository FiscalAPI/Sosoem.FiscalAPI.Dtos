using Sosoem.FiscalAPI.Dtos.Credentials;
using Sosoem.FiscalAPI.Dtos.Pacs.Sw.Invoice.Input;

namespace Sosoem.FiscalAPI.Dtos.Invoicing.Input;

public class InvoiceCancelInputModel
{
    /// <summary>
    /// Invoice uuid to be canceled.
    /// </summary>
    public string? InvoiceUuid { get; set; } = string.Empty;


    /// <summary>
    /// Issuer's Tax Identification Number.
    /// </summary>
    public string? Tin { get; set; } = string.Empty;

    /// <summary>
    /// Cancellation reason code.
    /// 01 Errors in relation to
    /// 02 Unrelated errors
    /// 03 The operation was not performed
    /// 04 Nominative transaction, related to a global invoice
    /// </summary>
    public string? CancellationReasonCode { get; set; } = string.Empty;


    /// <summary>
    /// Invoice uuid that replaces the invoice being cancelled.
    /// </summary>
    public string? ReplacementUuid { get; set; } = string.Empty;


    /// <summary>
    /// A list of files of type CredentialInputModel.
    /// Which represent the .cer and .key files of the tax authority in Mexico,
    /// with which the invoice is authenticated and signed.
    /// <see cref="CredentialInputModel"/>
    /// </summary>
    public List<CredentialInputModel>? Credentials { get; set; }

   
}