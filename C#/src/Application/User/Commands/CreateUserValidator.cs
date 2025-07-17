using Application.Dto.User;
using FluentValidation;

namespace Application.User.Commands;

public class CreateUserValidator : AbstractValidator<CreateUserDto>
{
    public CreateUserValidator()
    {
        RuleFor(u => u.EntraUserId).NotEmpty().MinimumLength(36).WithMessage("Please enter a valid Entra UserId");
        RuleFor(u => u.Role).NotEmpty().IsInEnum().WithMessage("Enter a valid Role");
    }
}
