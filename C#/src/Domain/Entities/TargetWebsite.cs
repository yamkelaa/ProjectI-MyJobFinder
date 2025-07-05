using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class TargetWebsite
{
    [Key]
    public int TargetWebsitedId { get; set; }
    [ForeignKey("UserId")]
    public int UserId { get; set; }
    [Required]
    [Url]
    [MaxLength(2048)]
    public required string Link { get; set; }
    [Required]
    [DataType(DataType.Password)]
    public required string Password { get; set; }
}
