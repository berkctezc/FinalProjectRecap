using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationResolvers.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotNull().MinimumLength(1).MaximumLength(20);
            RuleFor(u => u.LastName).NotNull().MinimumLength(1).MaximumLength(20);
            RuleFor(u => u.Email).NotNull().EmailAddress();
            RuleFor(u => u.Password).NotNull();
        }
    }
}