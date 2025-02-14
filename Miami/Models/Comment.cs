namespace Miami.Models;

public class Comment
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; } = string.Empty;
    public DateTime Date { get; set; } = DateTime.Now;
    public int? StockId { get; set; }
    public Stock? Stock { get; set; }
}