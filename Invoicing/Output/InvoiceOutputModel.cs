namespace Sosoem.FiscalAPI.Dtos.Invoicing.Output;

/// <summary>
/// Invoice output DTO.
/// </summary>
public class InvoiceOutputModel
{
    /// <summary>
    /// FiscalAPI Invoice's Id.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// TipoDeComprobante
    /// Atributo requerido para expresar la clave del efecto del comprobante fiscal para el contribuyente emisor.
    /// I	Ingreso
    /// E	Egreso
    /// T	Traslado
    /// N	Nómina
    /// P	Pago
    /// </summary>
    public string? InvoiceTypeCode { get; set; }

    /// <summary>
    /// Version
    /// Atributo requerido con valor prefijado a 4.0 que indica la versión del estándar bajo el que se encuentra expresado el comprobante.
    /// </summary>
    public string? Version { get; set; }


    /// <summary>
    /// Serie
    /// Atributo opcional para precisar la serie para control interno del contribuyente.
    /// Este atributo acepta una cadena de caracteres.
    /// </summary>
    public string? Series { get; set; }

    /// <summary>
    /// Folio
    /// Atributo opcional para control interno del contribuyente que expresa el folio del comprobante, acepta una cadena de caracteres.
    /// </summary>
    public string? Number { get; set; }


    /// <summary>
    /// Fecha
    /// Atributo requerido para la expresión de la fecha y hora de expedición del Comprobante Fiscal Digital por Internet.
    /// Debe corresponder con la hora local donde se expide el comprobante.
    /// Format YYYY-MM-DDThh:mm:ss
    /// </summary>
    public DateTime Date { get; set; }


    /// <summary>
    /// FormaPago
    /// Atributo condicional para expresar la clave de la forma de pago de los bienes o servicios amparados por el comprobante.
    /// 01	Efectivo
    /// 02	Cheque nominativo
    /// 03	Transferencia electrónica de fondos
    /// 04	Tarjeta de crédito
    /// 05	Monedero electrónico
    /// 06	Dinero electrónico
    /// 08	Vales de despensa
    /// 12	Dación en pago
    /// 13	Pago por subrogación
    /// 14	Pago por consignación
    /// 15	Condonación
    /// 17	Compensación
    /// 23	Novación
    /// 24	Confusión
    /// 25	Remisión de deuda
    /// 26	Prescripción o caducidad
    /// 27	A satisfacción del acreedor
    /// 28	Tarjeta de débito
    /// 29	Tarjeta de servicios
    /// 30	Aplicación de anticipos
    /// 31	Intermediario pagos
    /// 99	Por definir
    /// </summary>
    public string? PaymentFormCode { get; set; }


    /// <summary>
    /// Unofficial payment conditions
    /// C000	"Contado"
    /// C001	"Anticipado"
    /// C007	"7 Dias"
    /// C015	"15 Dias"
    /// C030	"30 Dias"
    /// C045	"45 Dias"
    /// C060	"60 Dias"
    /// C090	"90 Dias"
    /// C120	"120 Dias"
    /// Atributo condicional para expresar las condiciones comerciales aplicables para el pago del comprobante fiscal digital por Internet. Este atributo puede ser condicionado mediante atributos o complementos.
    /// </summary>
    public string? PaymentConditionCode { get; set; }


    /// <summary>
    /// Moneda
    /// Atributo requerido para identificar la clave de la moneda utilizada para expresar los montos, cuando se usa moneda nacional se registra MXN. Conforme con la especificación ISO 4217.
    /// MXN Peso Mexicano
    /// EUR	Euro
    /// BRL	Real brasileño
    /// USD	Dólar americano
    /// </summary>
    public string? CurrencyCode { get; set; }

    /// <summary>
    /// TipoCambio
    /// Atributo condicional para representar el tipo de cambio FIX conforme con la moneda usada.
    /// Es requerido cuando la clave de moneda es distinta de MXN y de XXX. El valor debe reflejar el número de pesos mexicanos que equivalen a una unidad de la divisa señalada en el atributo moneda.
    /// Si el valor está fuera del porcentaje aplicable a la moneda tomado del catálogo c_Moneda, el emisor debe obtener del PAC que vaya a timbrar el CFDI, de manera no automática, una clave de confirmación para ratificar que el valor es correcto e integrar dicha clave en el atributo Confirmacion.
    /// </summary>
    public decimal ExchangeRate { get; set; }


    /// <summary>
    /// MetodoPago
    /// Atributo condicional para precisar la clave del método de pago que aplica para este comprobante fiscal digital por Internet, conforme al Artículo 29-A fracción VII incisos a y b del CFF.
    /// PUE	Pago en una sola exhibición
    /// PPD	Pago en parcialidades o diferido
    /// </summary>
    public string? PaymentMethodCode { get; set; }

    /// <summary>
    /// uuid
    /// </summary>
    public string? InvoiceUuid { get; set; } = string.Empty;

    public decimal SubTotal { get; set; }
    public decimal Discount { get; set; }
    public decimal Taxes { get; set; }
    public decimal Total { get; set; }


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
    public string? InvoiceSignatureDate { get; set; } = string.Empty;


    /// <summary>
    /// Qr Code image in base64
    /// </summary>
    public string? Base64InvoiceQrCode { get; set; } = string.Empty;

    /// <summary>
    /// Signed CFDI by the SAT in base 64
    /// </summary>
    public string? Base64Invoice { get; set; } = string.Empty;


    /// <summary>
    /// Exportacion
    /// Atributo requerido para expresar si el comprobante ampara una operación de exportación.
    /// 01	No aplica
    /// 02	Definitiva con clave A1
    /// 03	Temporal
    /// 04	Definitiva con clave distinta a A1 o cuando no existe enajenación en términos del CFF.
    /// </summary>
    public string? ExportCode { get; set; } = "01";


    /// <summary>
    /// Emisor
    /// Nodo requerido para expresar la información del contribuyente emisor del comprobante.
    /// </summary>
    public PersonOutputModel? InvoiceIssuer { get; set; }


    /// <summary>
    /// Receptor
    /// Nodo requerido para precisar la información del contribuyente receptor del comprobante.
    /// </summary>
    public PersonOutputModel? InvoiceRecipient { get; set; }

    /// <summary>
    /// Conceptos
    /// Nodo requerido para listar los conceptos cubiertos por el comprobante.
    /// </summary>

    public List<InvoiceItemOutputModel> Items { get; set; } = new();


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
    public List<RelatedInvoiceOutputModel> RelatedInvoices { get; set; } = new();

    /// <summary>
    /// The invoices raw response, escially usefull for developers.
    /// It contains everything you need for physical purposes such as the XML, the original string, the stamps, certificate numbers, PDF QR Code, etc.
    /// 95% of the time it only returns a single response in side the list, it will return an additional response for each retry of stamping with the SAT.
    /// </summary>
    public List<InvoiceResponseOutputModel> RawResponses { get; set; } = new();

    public DateTime CreatedAt { get; set; }
    public string CreatedBy { get; set; } = string.Empty;
    public DateTime? UpdatedAt { get; set; }
    public string? UpdatedBy { get; set; }
}