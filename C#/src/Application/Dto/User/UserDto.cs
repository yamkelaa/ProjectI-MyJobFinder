using Domain.Enums;

namespace Application.Dto.User;

public class UserDto
{
    public int UserId { get; set; }
    public required string  EntraUserId { get; set; }
    public required Role Role { get; set; }
}
