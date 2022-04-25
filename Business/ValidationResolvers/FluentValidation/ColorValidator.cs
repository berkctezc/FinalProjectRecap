using Entities.Concrete;
using FluentValidation;


namespace Business.ValidationResolvers.FluentValidation;

public class ColorValidator : AbstractValidator<Color>
{
    public ColorValidator()
    {
        RuleFor(c => c.Name).MinimumLength(2);
        RuleFor(c => c.Name).NotEmpty();
    }
}