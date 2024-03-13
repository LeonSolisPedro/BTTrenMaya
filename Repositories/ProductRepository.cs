using signalR101.Interfaces;
using signalR101.Models;

namespace signalR101.Repositories;

public class ProductRepository : BaseRepository<Product>, IProductRepository
{
  public ProductRepository(AppDbContext context) : base(context)
  {
  }
}
