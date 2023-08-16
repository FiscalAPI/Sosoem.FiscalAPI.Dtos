namespace Sosoem.FiscalAPI.Dtos.Invoicing.Complements.Payment.Input;

/// <summary>
/// Elemento: DoctoRelacionado
/// Nodo requerido para expresar la lista de documentos relacionados con los pagos.
/// Por cada documento que se relacione se debe generar un nodo DoctoRelacionado.
/// 
/// When a payment invoice is issued, it means that the issuing company is receiving payment from a customer.
/// That payment received is usually paying several invoices called 'PaidInvoice' (DoctoRelacionado).
/// This class represents each  paid invoice with that received payment. 
/// </summary>
public class PaidInvoiceInputModel
{
    /// <summary>
    /// IdDocumento
    /// Atributo requerido para expresar el identificador del documento relacionado con el pago. Este dato puede ser un Folio Fiscal de la Factura Electrónica o bien el número de operación de un documento digital.
    /// </summary>

    public string InvoiceUuid { get; set; } = string.Empty;

    /// <summary>
    /// Serie
    /// Atributo opcional para precisar la serie del comprobante para control interno del contribuyente, acepta una cadena de caracteres.
    /// </summary>
    public string InvoiceSeries { get; set; } = string.Empty;

    /// <summary>
    /// Folio
    /// Atributo opcional para precisar el folio del comprobante para control interno del contribuyente, acepta una cadena de caracteres.
    /// </summary>
    public string InvoiceNumber { get; set; } = string.Empty;


    /// <summary>
    /// MonedaDR
    /// Atributo requerido para identificar la clave de la moneda utilizada en los importes del documento relacionado, cuando se usa moneda nacional o el documento relacionado no especifica la moneda se registra MXN. Los importes registrados en los atributos “ImpSaldoAnt”, “ImpPagado” e “ImpSaldoInsoluto” de éste nodo, deben corresponder a esta moneda. Conforme con la especificación ISO 4217.
    /// </summary>
    public string InvoiceCurrencyCode { get; set; } = string.Empty;


    /// <summary>
    /// NumParcialidad
    /// Atributo requerido para expresar el número de parcialidad que corresponde al pago.
    /// </summary>
    public int PartialityNumber { get; set; }

    /// <summary>
    /// ImpSaldoAnt
    /// Attribute required to calculate paid invoice taxes and payment taxes.
    /// </summary>
    public decimal SubTotal { get; set; }

    /// <summary>
    /// ImpSaldoAnt
    /// Atributo requerido para expresar el monto del saldo insoluto de la parcialidad anterior. En el caso de que sea la primer parcialidad este atributo debe contener el importe total del documento relacionado.
    /// </summary>
    public decimal PreviousBalanceAmount { get; set; }


    /// <summary>
    /// ImpPagado
    /// Atributo requerido para expresar el importe pagado para el documento relacionado.
    /// </summary>
    public decimal PaymentAmount { get; set; }


    /// <summary>
    /// ImpSaldoInsoluto
    /// Atributo requerido para expresar la diferencia entre el importe del saldo anterior y el monto del pago.
    /// </summary>
    public decimal RemainingBalance { get; set; }


    /// <summary>
    /// ObjetoImpDR
    /// Atributo requerido para expresar si el pago del documento relacionado es objeto o no de impuesto.
    /// </summary>  
    public string TaxObjectCode { get; set; } = string.Empty;


    public List<PaidInvoiceTaxInputModel> PaidInvoiceTaxes { get; set; } = new();
}