using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class SentEmail
{
    [Key]
    public int EmailId { get; set; }
    [ForeignKey("UserId")]
    public int UserId { get; set; }
    [ForeignKey("TargetEmailAddressId")]
    public int TargetEmailAddressId { get; set; }
    [Required]
    public bool IsEmailSent { get; set; }
    [Required]
    public DateTime SentDate { get; set; }
}