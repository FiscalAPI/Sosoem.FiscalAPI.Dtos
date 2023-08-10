namespace Sosoem.FiscalAPI.Dtos.Pacs.Sw.InvoiceRetrieving.Input;

public class InvoiceRetrieveInputModel
{
    public string InvoiceUuid { get; set; } = string.Empty;

    public string IssuerTin { get; set; } = string.Empty;

    public string RecipientTin { get; set; } = string.Empty;
    public string InvoiceAmount { get; set; } = string.Empty;

    /// <summary>
    ///  Last eight digits of the Signature Value
    /// </summary>
    public string InvoiceSignatureValue { get; set; } = string.Empty;
}