namespace Sosoem.FiscalAPI.Dtos.Invoicing;
/// <summary>
/// Nodo requerido para expresar la información del contribuyente emisor del comprobante
/// </summary>
public class InvoiceIssuerInputModel
{
    /// <summary>
    /// Rfc
    /// Atributo requerido para registrar la Clave del Registro Federal de Contribuyentes correspondiente al contribuyente emisor del comprobante.
    /// </summary>
    public string? Tin { get; set; }


    /// <summary>
    /// Nombre
    /// Atributo requerido para registrar el nombre, denominación o razón social del contribuyente inscrito en el RFC, del emisor del comprobante.
    /// </summary>

    public string? LegalName { get; set; }


    /// <summary>
    /// RegimenFiscal
    /// Atributo requerido para incorporar la clave del régimen del contribuyente emisor al que aplicará el efecto fiscal de este comprobante.
    /// 601	General de Ley Personas Morales
    /// 603	Personas Morales con Fines no Lucrativos
    /// 605	Sueldos y Salarios e Ingresos Asimilados a Salarios
    /// 606	Arrendamiento
    /// 607	Régimen de Enajenación o Adquisición de Bienes
    /// 608	Demás ingresos
    /// 610	Residentes en el Extranjero sin Establecimiento Permanente en México
    /// 611	Ingresos por Dividendos (socios y accionistas)
    /// 612	Personas Físicas con Actividades Empresariales y Profesionales
    /// 614	Ingresos por intereses
    /// 615	Régimen de los ingresos por obtención de premios
    /// 616	Sin obligaciones fiscales
    /// 620	Sociedades Cooperativas de Producción que optan por diferir sus ingresos
    /// 621	Incorporación Fiscal
    /// 622	Actividades Agrícolas, Ganaderas, Silvícolas y Pesqueras
    /// 623	Opcional para Grupos de Sociedades
    /// 624	Coordinados
    /// 625	Régimen de las Actividades Empresariales con ingresos a través de Plataformas Tecnológicas
    /// 626	Régimen Simplificado de Confianza
    /// </summary>
    public string? TaxRegimeCode { get; set; }


    /// <summary>
    /// FacAtrAdquirente
    /// Atributo condicional para expresar el número de operación proporcionado por el SAT cuando se trate de un comprobante a través de un PCECFDI o un PCGCFDISP.
    /// </summary>
    public string? OperationNumber { get; set; }
}