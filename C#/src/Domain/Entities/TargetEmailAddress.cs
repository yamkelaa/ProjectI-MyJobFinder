using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class TargetEmailAddress
{
    [Key]
    public int TargetEmailId { get; set; }
    [ForeignKey("User")]
    public int UserId { get; set; }
    [Required]
    [EmailAddress]
    [MaxLength(256)]
    public required string Address { get; set; }
    public required User User { get; set; }
}
