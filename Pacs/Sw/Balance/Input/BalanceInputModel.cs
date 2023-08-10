namespace Sosoem.FiscalAPI.Dtos.Pacs.Sw.Balance.Input;

public class BalanceInputModel
{
    public string UserId { get; set; } = string.Empty;
    public int Quantity { get; set; } = 0;
    public string Comment { get; set; } = string.Empty;
}