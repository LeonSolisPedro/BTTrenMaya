using System.ComponentModel.DataAnnotations;

namespace signalR101.Models;

public class BaseModel
{
  [Key]
  public Guid Id { get; set; }
  public bool IsDelete { get; set; }
}
