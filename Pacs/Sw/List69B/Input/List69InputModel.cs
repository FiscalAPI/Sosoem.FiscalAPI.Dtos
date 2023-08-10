using System.Text.Json.Serialization;

namespace Sosoem.FiscalAPI.Dtos.Pacs.Sw.List69B.Input;

public class List69InputModel
{
    /// <summary>
    /// Mexican Tax Identification Number (RFC)
    /// </summary>
    public string Tin { get; set; } = string.Empty;
}