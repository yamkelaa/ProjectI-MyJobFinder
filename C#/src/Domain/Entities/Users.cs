namespace Domain.Entities;

public class Users
{
    public int UserId { get; set; }
    public int EntraUserId { get; set; }
    public required string Role { get; set; }
}
