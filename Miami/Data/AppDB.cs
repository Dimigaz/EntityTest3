namespace Miami.Data;

using Microsoft.EntityFrameworkCore;
using Miami.Models;



public class AppDB : DbContext
{
    public AppDB(DbContextOptions dbContextOptions)
        : base(dbContextOptions)
    {
        
    }
    
    public DbSet<Stock> Stocks { get; set; }
    public DbSet<Comment> Comments { get; set; }
}