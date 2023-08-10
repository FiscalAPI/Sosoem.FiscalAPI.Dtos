using System.Text.Json.Serialization;

namespace Sosoem.FiscalAPI.Dtos.Pacs.Sw.Balance.Input;

/// <summary>
/// Balance comment for Add or Remove balance operations
/// </summary>
public class BalanceComment
{
    /// <summary>
    /// Any administrative reference.
    /// </summary>
    [JsonPropertyName("Comentario")]
    public string Comment { get; set; } = string.Empty;
}