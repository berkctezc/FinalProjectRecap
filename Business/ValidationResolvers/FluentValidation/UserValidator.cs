using Core.Entities.Concrete;
using FluentValidation;

namespace Business.ValidationResolvers.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty().NotNull().MinimumLength(1).MaximumLength(20);
            RuleFor(u => u.LastName).NotEmpty().NotNull().MinimumLength(1).MaximumLength(20);
            RuleFor(u => u.Email).NotEmpty().NotNull().EmailAddress();
        }
    }
}