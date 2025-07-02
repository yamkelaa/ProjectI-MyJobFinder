namespace Domain.Entities;

public class TargetEmailAddresses
{
    public int TargetEmailId { get; set; }
    public int UserId { get; set; }
    public required string TargetEmailAddress { get; set; }
}
