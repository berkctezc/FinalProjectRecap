using Business.Constants;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationResolvers.FluentValidation;

public class CarValidator : AbstractValidator<Car>
{
    public CarValidator()
    {
        RuleFor(c => c.DailyPrice).GreaterThan(0).WithMessage(Messages.CarDailyPriceInvalid);
        RuleFor(c => c.Description).MinimumLength(3);
    }
}