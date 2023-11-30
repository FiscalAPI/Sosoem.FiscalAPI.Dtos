
using Sosoem.FiscalAPI.Dtos.Enums;

namespace Sosoem.FiscalAPI.Dtos.Credentials;

public class CredentialOutputModel
{
    public string Id { get; set; } = string.Empty;
    public string PersonId { get; set; } = string.Empty;
    public string TaxIdentificationNumber { get; set; } = string.Empty;
    public string Base64File { get; set; } = string.Empty;
    public FileType FileType { get; set; }
    public string? Password { get; set; }
    public DateTime ValidFrom { get; set; }
    public DateTime ValidTo { get; set; }
    public string KeyPairPhrase { get; set; } = string.Empty;
}