﻿using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationResolvers.FluentValidation;

public class CarImageValidator : AbstractValidator<CarImage>
{
    public CarImageValidator()
    {
        RuleFor(c => c.CarId).NotNull();
        RuleFor(c => c.Id).NotNull();
    }
}