namespace Domain.Entities;

public class TargetWebsites
{
   public int TargetWebsitedId { get; set; }
    public int UserId { get; set; }
    public required string Link {  get; set; }
    public required string Password { get; set; }
}
