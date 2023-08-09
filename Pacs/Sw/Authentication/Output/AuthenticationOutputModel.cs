using System.Text.Json.Serialization;

namespace Sosoem.FiscalAPI.Dtos.Pacs.Sw.Authentication.Output
{
    public class AuthenticationOutputModel
    {
        [JsonPropertyName("token")] public string Token { get; set; } = string.Empty;
        [JsonPropertyName("expires_in")] public int ExpiresIn { get; set; }
        [JsonPropertyName("tokeny_type")] public string TokenType { get; set; } = string.Empty;
    }
}