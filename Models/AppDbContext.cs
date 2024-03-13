using Microsoft.EntityFrameworkCore;

namespace signalR101.Models;

public class AppDbContext : DbContext
{
  public AppDbContext(DbContextOptions options) : base(options)
  {

  }
  public DbSet<Product> Products { get; set; }

}
