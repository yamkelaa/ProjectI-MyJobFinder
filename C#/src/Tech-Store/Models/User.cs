using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Tech_Store.Models;

public partial class User
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Surname { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Role { get; set; } = null!;
}
