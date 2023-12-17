namespace Sosoem.FiscalAPI.Dtos.Invoicing.Output;

public class InvoiceItemTaxOutputModel
{
    /// <summary>
    /// FiscalAPI Invoice item tax's Id.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Impuesto
    /// Atributo requerido para señalar la clave del tipo de impuesto trasladado aplicable al concepto.
    /// 001	ISR
    /// 002	IVA
    /// 003	IEPS
    /// </summary>
    public string? TaxCode { get; set; }

    /// <summary>
    /// TipoFactor
    /// Atributo requerido para señalar la clave del tipo de factor que se aplica a la base del impuesto.
    /// Tasa
    /// Cuota
    /// Exento
    /// </summary>
    public string? TaxTypeCode { get; set; }

    /// <summary>
    /// TasaOCuota
    /// Atributo condicional para señalar el valor de la tasa o cuota del impuesto que se traslada para el presente concepto.
    /// Es requerido cuando el atributo TipoFactor tenga una clave que corresponda a Tasa o Cuota.
    /// 0.000000 	IVA	    Tasa
    /// 0.160000 	IVA	    Tasa
    /// 0.160000 	IVA	    Tasa
    /// 0.080000 	IVA     Tasa
    /// 0.265000 	IEPS	Tasa
    /// 0.300000 	IEPS	Tasa
    /// 0.530000 	IEPS	Tasa
    /// 0.500000 	IEPS	Tasa
    /// 1.600000 	IEPS	Tasa
    /// 0.304000 	IEPS	Tasa
    /// 0.250000 	IEPS	Tasa
    /// 0.090000 	IEPS	Tasa
    /// 0.080000 	IEPS	Tasa
    /// 0.070000 	IEPS	Tasa
    /// 0.060000 	IEPS	Tasa
    /// 0.030000 	IEPS	Tasa
    /// 0.000000 	IEPS	Tasa
    /// 59.144900 	IEPS	Cuota
    /// 0.350000 	ISR	    Tasa
    /// </summary>
    public decimal TaxRate { get; set; }

    /// <summary>
    /// Specifies the nature of the tax.
    /// Accepts two values the letter 'T' or the letter 'R'
    /// T: When the tax is a transferred tax.
    /// R: When the tax is a withholding tax.
    /// The default value is T TaxFlag
    /// </summary>
    public string TaxFlagCode { get; set; } = string.Empty;
}