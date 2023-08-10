using System.Text.Json.Serialization;

namespace Sosoem.FiscalAPI.Dtos.Pacs.Sw.Users.Output;

public class UserOutputModel
{
    [JsonPropertyName("stamps")] public int Stamps { get; set; }


    [JsonPropertyName("Unlimited")] public bool Unlimited { get; set; } = false;

    [JsonPropertyName("idUsuario")] public string UserId { get; set; } = string.Empty;

    [JsonPropertyName("idCliente")] public string CustomerId { get; set; } = string.Empty;

    [JsonPropertyName("nombre")] public string Name { get; set; } = string.Empty;

    [JsonPropertyName("apellidoPaterno")] public string Tin { get; set; } = string.Empty;

    [JsonPropertyName("username")] public string UserName { get; set; } = string.Empty;

    [JsonPropertyName("email")] public string Email { get; set; } = string.Empty;

    [JsonPropertyName("activo")] public bool IsActive { get; set; }

    [JsonPropertyName("eliminado")] public bool IsDeleted { get; set; }

    [JsonPropertyName("tokenAccess")] public string InfiniteAccessToken { get; set; } = string.Empty;
}