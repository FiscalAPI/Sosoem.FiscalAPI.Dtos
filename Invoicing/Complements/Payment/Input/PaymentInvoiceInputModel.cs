using Sosoem.FiscalAPI.Dtos.Invoicing.Input;

namespace Sosoem.FiscalAPI.Dtos.Invoicing.Complements.Payment.Input;

/// <summary>
/// Payment invoice
/// </summary>
public class PaymentInvoiceInputModel : InvoiceInputModel
{
    /// <summary>
    /// Elemento: Pagos > Elemento: Pago
    /// The root payment object of the payment invoice.
    /// It represents the node of the received payment, the reason for issuing the payment invoice. 
    /// </summary>

    public PaidPaymentInputModel PaidPayment { get; set; } = new();
}