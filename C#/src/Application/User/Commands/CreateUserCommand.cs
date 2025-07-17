using Application.Dto.User;
using Application.Interfaces.Command;

namespace Application.User.Commands;

public record CreateUserCommand(CreateUserDto createUserDto) : ICommand<UserDto>
{

}
