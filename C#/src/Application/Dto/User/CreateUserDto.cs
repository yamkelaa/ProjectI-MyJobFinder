using Domain.Enums;

namespace Application.Dto.User;

public class CreateUserDto
{
    public required string EntraUserId { get; set; }
    public required Role Role { get; set; }
}
