namespace Miami.Models;

public class Stock
{
    public int Id { get; set; }
    public string Symbol { get; set; } = String.Empty;
    public string CompanyName { get; set; } = String.Empty;
    public string Industry { get; set; } = String.Empty;
    public decimal PurchasePrice { get; set; }
    
    public decimal LastDiv { get; set; }
    
    public long MarketCap { get; set; }
    
    public List<Comment> Comments { get; set; } = new List<Comment>();
    
    
    
}