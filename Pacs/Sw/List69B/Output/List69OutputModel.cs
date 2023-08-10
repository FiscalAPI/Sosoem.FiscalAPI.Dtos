using System.Text.Json.Serialization;

namespace Sosoem.FiscalAPI.Dtos.Pacs.Sw.List69B.Output;

public class List69OutputModel
{
    [JsonPropertyName("id")] public string? Id { get; set; }
    [JsonPropertyName("rfc")] public string? Tin { get; set; }

    [JsonPropertyName("nombre_Contribuyente")]
    public string? TaxpayerName { get; set; }

    [JsonPropertyName("situacion_del_contribuyente")]
    public string? TaxpayerStatus { get; set; }

    [JsonPropertyName("numero_y_fecha_oficio_global_presuncion")]
    public string? NumberAndDateOfGlobalPresumptiveDocument { get; set; }

    [JsonPropertyName("publicacion_pagina_SAT_presuntos")]
    public string? PublicationPresumptionsSatPage { get; set; }

    [JsonPropertyName("publicacion_DOF_presuntos")]
    public string PublicacionDofPresuntos { get; set; }

    [JsonPropertyName("publicacion_pagina_SAT_desvirtuados")]
    public string PublicacionPaginaSatDesvirtuados { get; set; }

    [JsonPropertyName("numero_fecha_oficio_global_contribuyentes_que_desvirtuaron")]
    public string? GlobalDocumentDateNumberOfTaxpayersDistorted { get; set; }

    [JsonPropertyName("publicacion_DOF_desvirtuados")]
    public string? DofDevirtuatedPublication { get; set; }

    [JsonPropertyName("numero_fecha_oficio_global_definitivos")]
    public string? GlobalDocumentDateNumberDefinitive { get; set; }

    [JsonPropertyName("publicacion_pagina_SAT_definitivos")]
    public string? SatPublicationPageDefinitive { get; set; }

    [JsonPropertyName("publicacion_DOF_definitivos")]
    public string? DofDefinitivesPublication { get; set; }

    [JsonPropertyName("numero_fecha_oficio_global_sentencia_favorable")]
    public string? GlobalDocumentDateNumberFavorableJudgment { get; set; }

    [JsonPropertyName("publicacion_pagina_SAT_sentencia_favorable")]
    public string? SatPublicationPageFavorableSentence { get; set; }

    [JsonPropertyName("publicacion_DOF_sentencia_favorable")]
    public string? DofPublicationFavorableSentence { get; set; }
}