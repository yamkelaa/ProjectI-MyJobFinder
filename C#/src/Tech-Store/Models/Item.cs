using System.ComponentModel.DataAnnotations;

namespace Tech_Store.Models;

public partial class Item
{
    [Key]
    public int Id { get; set; }
    [Required]
    public required string Name { get; set; }
    public double Price { get; set; } 
}
