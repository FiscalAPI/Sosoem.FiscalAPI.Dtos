using System.Text.Json.Serialization;

namespace Sosoem.FiscalAPI.Dtos.Pacs.Sw.Balance.Output;

public class BalanceOutputModel
{

    [JsonPropertyName("idClienteUsuario")] public string UserId { get; set; } = string.Empty;

    [JsonPropertyName("saldoTimbres")] public int Stamps { get; set; }


    [JsonPropertyName("unlimited")] public bool IsUnlimited { get; set; }


}