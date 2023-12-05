using Sosoem.FiscalAPI.Dtos.Credentials;

namespace Sosoem.FiscalAPI.Dtos.Invoicing.Input;

public class PersonInputModel 
{

    public string? Id { get; set; }

    /// <summary>
    /// Rfc
    /// Atributo requerido para registrar la Clave del Registro Federal de Contribuyentes correspondiente al contribuyente receptor del comprobante.
    /// </summary>
    public string Tin { get; set; } = string.Empty;

    /// <summary>
    /// Nombre
    /// Atributo requerido para registrar el nombre(s), primer apellido, segundo apellido, según corresponda, denominación o razón social del contribuyente, inscrito en el RFC, del receptor del comprobante.
    /// </summary>
    public string LegalName { get; set; } = string.Empty;

    /// <summary>
    /// Código postal del domicilio fiscal.
    /// Atributo requerido para registrar el código postal del domicilio fiscal del receptor del comprobante.
    /// </summary>
    public string ZipCode { get; set; } = string.Empty;


    /// <summary>
    /// RegimenFiscalReceptor
    /// Atributo requerido para incorporar la clave del régimen fiscal del contribuyente receptor al que aplicará el efecto fiscal de este comprobante.
    /// </summary>
    public string TaxRegimeCode { get; set; } = string.Empty;


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

    /// <summary>
    /// It represents the envelope of the .cer and .key files,
    /// which the tax authority delivers to the taxpayer,
    /// also known as 'Sellos SAT ' or SAT tax credentials.
    /// </summary>
    public List<CredentialInputModel>? TaxCredentials { get; set; }
}