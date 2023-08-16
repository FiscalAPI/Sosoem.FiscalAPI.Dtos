namespace Sosoem.FiscalAPI.Dtos.Invoicing.Input;
/// <summary>
/// Nodo requerido para precisar la información del contribuyente receptor del comprobante
/// </summary>
public class InvoiceRecipientInputModel
{
    /// <summary>
    /// Rfc
    /// Atributo requerido para registrar la Clave del Registro Federal de Contribuyentes correspondiente al contribuyente receptor del comprobante.
    /// </summary>
    public string? Tin { get; set; }

    /// <summary>
    /// Nombre
    /// Atributo requerido para registrar el nombre(s), primer apellido, segundo apellido, según corresponda, denominación o razón social del contribuyente, inscrito en el RFC, del receptor del comprobante.
    /// </summary>
    public string? LegalName { get; set; }

    /// <summary>
    /// DomicilioFiscalReceptor
    /// Atributo requerido para registrar el código postal del domicilio fiscal del receptor del comprobante.
    /// </summary>
    public string? ZipCode { get; set; }


    /// <summary>
    /// ResidenciaFiscal
    /// Atributo condicional para registrar la clave del país de residencia para efectos fiscales del receptor del comprobante, cuando se trate de un extranjero, y que es conforme con la especificación ISO 3166-1 alpha-3.
    /// Es requerido cuando se incluya el complemento de comercio exterior o se registre el atributo NumRegIdTrib.
    /// </summary>
    public string? ForeignCountryId { get; set; }


    /// <summary>
    /// NumRegIdTrib
    /// Atributo condicional para expresar el número de registro de identidad fiscal del receptor cuando sea residente en el extranjero.
    /// Es requerido cuando se incluya el complemento de comercio exterior.
    /// </summary>
    public string? ForeignTin { get; set; }


    /// <summary>
    /// RegimenFiscalReceptor
    /// Atributo requerido para incorporar la clave del régimen fiscal del contribuyente receptor al que aplicará el efecto fiscal de este comprobante.
    /// </summary>
    public string? TaxRegimeCode { get; set; }


    /// <summary>
    /// UsoCFDI
    /// Atributo requerido para expresar la clave del uso que dará a esta factura el receptor del CFDI.
    /// </summary>
    public string? CfdiUseCode { get; set; }


    /// <summary>
    /// E-mail where the XML and PDF will be sent.
    /// Optional attribute and used exclusively to send the pdf and XML by mail.
    /// This attribute has no relation with the miscellaneous tax resolution,
    /// so it can be omitted without any difference in the result, only the invoice is not sent by mail. 
    /// </summary>
    public string? Email { get; set; }
}