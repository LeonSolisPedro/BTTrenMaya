using System.ComponentModel.DataAnnotations;

namespace signalR101.Models;

public class Product : BaseModel
{
  [Required]
  public string Name { get; set; }
  public double Price { get; set; }
  public bool IsAvailable { get; set; }
}
