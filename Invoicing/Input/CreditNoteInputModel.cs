namespace Sosoem.FiscalAPI.Dtos.Invoicing.Input;

public class CreditNoteInputModel : InvoiceInputModel
{
    /// <summary>
    /// Invoice or invoices to which the credit note will be applied.
    /// You must choose the same type of relationship for all related invoices.
    /// <value>01	Nota de crédito de los documentos relacionados</value>
    /// <value>02	Nota de débito de los documentos relacionados</value>
    /// <value>03	Devolución de mercancía sobre facturas o traslados previos</value>
    /// <value>04	Sustitución de los CFDI previos</value>
    /// <value>05	Traslados de mercancías facturados previamente</value>
    /// <value>06	Factura generada por los traslados previos</value>
    /// <value>07	CFDI por aplicación de anticipo</value>
    /// </summary>
    //public List<RelatedInvoiceModel> RelatedInvoices { get; set; } = new();
}