using System.Text.Json.Serialization;

namespace Sosoem.FiscalAPI.Dtos.Pacs.Sw.Users.Input;

/// <summary>
/// PUT User Update
/// </summary>
public class UserUpdateInputModel
{
    /// <summary>
    /// Legal Name
    /// </summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>
    /// Mexican Tax Identification Number
    /// </summary>
    [JsonPropertyName("Rfc")]
    public string? Tin { get; set; }

    /// <summary>
    /// Indicates whether the user has unlimited dealer signatures.
    /// </summary>
    [JsonPropertyName("Unlimited")]
    public bool Unlimited { get; set; }

    /// <summary>
    /// Flag that indicates if the user is active in the pac
    /// </summary>

    [JsonPropertyName("active")]
    public bool Active { get; set; }
}