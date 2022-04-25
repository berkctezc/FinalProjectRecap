using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationResolvers.FluentValidation;

public class CustomerValidator : AbstractValidator<Customer>
{
    public CustomerValidator()
    {
        RuleFor(c => c.CompanyName).NotEmpty();
        RuleFor(c => c.CompanyName).MinimumLength(5);
        RuleFor(c => c.UserId).NotNull();
    }
}