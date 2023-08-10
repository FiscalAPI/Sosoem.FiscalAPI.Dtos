namespace Sosoem.FiscalAPI.Dtos.Common;

public static class GlobalConstants
{
    public const string SatDateFormat = "yyyy-MM-ddTHH:mm:ss";
    public const string SatInvoiceNationalTin = "XAXX010101000";
    public const string SatInvoiceForeignTin = "XEXX010101000";
    public const string SatInvoiceItemId = "01010101";
    public const string SatInvoiceUnitOfMeasureId = "H87";
    public const string SatInvoiceObjectId = "02"; //Sí objeto de impuesto;

    public const string SatPaymentItemId = "84111506";
    public const string SatPaymentUnitOfMeasureId = "ACT";
    public const string SatPaymentItemDescriptionId = "Pago";
    public const string SatPaymentObjectId = "01"; //No objeto de impuesto).;


    #region HttpClients

    public const string ServicesBaseAddressTest = "https://services.test.sw.com.mx";
    public const string ServicesBaseAddressProd = "https://services.sw.com.mx";
    public const string ApiBaseAddressTest = "http://api.test.sw.com.mx";
    public const string ApiBaseAddressProd = "https://api.sw.com.mx";

    public const string ServicesHttpClientNameTest = "ServicesHttpClientNameTest";
    public const string ServicesHttpClientNameProd = "ServicesHttpClientNameProd";
    public const string ApiHttpClientNameTest = "ApiHttpClientNameTest";
    public const string ApiHttpClientNameProd = "ApiHttpClientNameProd";

    #endregion

    public const string Success = "success";
    public const string Error = "error";
}