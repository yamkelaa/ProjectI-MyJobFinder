using Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class User
{
    [Key]
    public int UserId { get; set; }
    [Required]
    [StringLength(36, MinimumLength =36)]
    public int EntraUserId { get; set; }
    [Required]
    [EnumDataType(typeof(Role))]
    public required Role Role { get; set; }
}
