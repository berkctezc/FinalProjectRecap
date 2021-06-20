using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationResolvers.FluentValidation
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(b => b.Name).MinimumLength(2).NotEmpty();
        }
    }
}