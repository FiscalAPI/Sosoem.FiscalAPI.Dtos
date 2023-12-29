namespace Sosoem.FiscalAPI.Dtos.Invoicing.Output;

/// <summary>
/// Nodo requerido para listar los conceptos cubiertos por el comprobante.
/// </summary>
public class InvoiceItemOutputModel
{
    /// <summary>
    /// FiscalAPI Invoice item's Id.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// ClaveProdServ
    /// Atributo requerido para expresar la clave del producto o del servicio amparado por el presente concepto. Es requerido y deben utilizar las claves del catálogo de productos y servicios, cuando los conceptos que registren por sus actividades correspondan con dichos conceptos.
    /// 01010101	No existe en el catálogo
    /// ...
    /// </summary>
    public string? ItemCode { get; set; }

    /// <summary>
    /// NoIdentificacion
    /// Atributo opcional para expresar el número de parte, identificador del producto o del servicio, la clave de producto o servicio, SKU o equivalente, propia de la operación del emisor, amparado por el presente concepto. Opcionalmente se puede utilizar claves del estándar GTIN.
    /// </summary>
    public string? ItemId { get; set; }


    /// <summary>
    /// Cantidad
    /// Atributo requerido para precisar la cantidad de bienes o servicios del tipo particular definido por el presente concepto.
    /// </summary>
    public decimal Quantity { get; set; }


    /// <summary>
    /// ClaveUnidad
    /// Atributo requerido para precisar la clave de unidad de medida estandarizada aplicable para la cantidad expresada en el concepto.
    /// La unidad debe corresponder con la descripción del concepto.
    /// H87	Pieza
    /// ...
    /// </summary>
    public string? UnitOfMeasureCode { get; set; }


    /// <summary>
    /// Unidad
    /// Atributo opcional para precisar la unidad de medida propia de la operación del emisor, aplicable para la cantidad expresada en el concepto.
    /// La unidad debe corresponder con la descripción del concepto.
    /// </summary>
    public string? UnitOfMeasure { get; set; }

    /// <summary>
    /// Descripcion
    /// Atributo requerido para precisar la descripción del bien o servicio cubierto por el presente concepto.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// ValorUnitario
    /// Atributo requerido para precisar el valor o precio unitario del bien o servicio cubierto por el presente concepto.
    /// </summary>
    public decimal UnitPrice { get; set; }

    //public decimal Amount { get; set; }

    /// <summary>
    /// Descuento
    /// Atributo opcional para representar el importe de los descuentos aplicables al concepto.
    /// No se permiten valores negativos.
    /// </summary>
    public decimal Discount { get; set; }

    /// <summary>
    /// Atributo requerido para expresar si la operación comercial es objeto o no de impuesto.
    /// 01	No objeto de impuesto.
    /// 02	Sí objeto de impuesto.
    /// 03	Sí objeto del impuesto y no obligado al desglose.
    /// 04	Sí objeto del impuesto y no causa impuesto.
    /// </summary>
    public string? TaxObjectCode { get; set; }

    //public decimal Total  { get; set; }
    /// <summary>
    /// Impuestos
    /// Nodo condicional para capturar los impuestos aplicables al presente concepto.
    /// </summary>
    public List<InvoiceItemTaxOutputModel>? ItemTaxes { get; set; }
}