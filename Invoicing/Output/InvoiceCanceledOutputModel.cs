namespace Sosoem.FiscalAPI.Dtos.Invoicing.Output;

public class InvoiceCanceledOutputModel
{
    /// <summary>
    /// XML Acknowledgement of cancellation encoded to base 64.
    /// To retrieve the raw XML you must decode using the DecodeFromBase64() extension method.
    /// </summary>
    public string? Base64CancellationAcknowledgement { get; set; }

    /// <summary>
    /// List of canceled invoice uuids. Or list of  invoice uuids in proccess to be canceled.
    /// </summary>
    public Dictionary<string, string>? InvoiceUuids { get; set; }
}