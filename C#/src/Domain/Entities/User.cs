using Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class User
{
    [Key]
    public int UserId { get; set; }
    [Required]
    [StringLength(36, MinimumLength =36)]
    public required string EntraUserId { get; set; }
    [Required]
    [EnumDataType(typeof(Role))]
    public required Role Role { get; set; }
    public ICollection<TargetEmailAddress>? EmailAddresses { get; set; }
    public ICollection <TargetWebsite>? Websites { get; set; }
}
