using System.Text.Json.Serialization;

namespace Sosoem.FiscalAPI.Dtos.Pacs.Sw.Users.Input;

public class UserCreateInputModel
{
    /// <summary>
    /// Email
    /// </summary>
    [JsonPropertyName("Email")]
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// Password
    /// The password must not be the same as the username.
    /// The password must include at least one uppercase letter.
    /// The password must include at least one lowercase letter.
    /// The password must include at least one number.
    /// The password must include at least one symbol (special character).
    /// The password must not include blank spaces.
    /// The password must be between 10 and 20 characters long.
    /// The password must not include any unusual special symbols.
    /// The following special characters are accepted: !@#$%^&*()_+=\[{\]};:<>|./?,-]
    /// </summary>
    [JsonPropertyName("Password")]
    public string Password { get; set; } = string.Empty;

    /// <summary>
    /// Legal Name
    /// </summary>
    [JsonPropertyName("Name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Mexican Tax Identification Number
    /// </summary>
    [JsonPropertyName("RFC")]
    public string Tin { get; set; } = string.Empty;

    /// <summary>
    /// Always 3
    /// </summary>
    [JsonPropertyName("Profile")]
    public int Profile { get; set; } = 3;

    /// <summary>
    /// Initial pac signatures
    /// </summary>
    [JsonPropertyName("Stamps")]
    public int Stamps { get; set; } = 0;

    /// <summary>
    /// Indicates whether the user has unlimited dealer signatures.
    /// </summary>
    [JsonPropertyName("Unlimited")]
    public bool Unlimited { get; set; } = false;

    /// <summary>
    /// Flag that indicates if the user is active in the pac
    /// </summary>
    [JsonPropertyName("Active")]
    public bool Active { get; set; } = true;
}