namespace Sosoem.FiscalAPI.Dtos.Pacs.Sw.Invoice.Input;

public class IssueInvoiceInputModel
{
    public string Token { get; set; } = string.Empty;
    public string ContentType { get; set; } = string.Empty;
    public string InvoiceUuid { get; set; } = string.Empty;
    public string InvoiceBase64 { get; set; } = string.Empty;
}