using System;
using System.Collections.Generic;
using TraineeShop.Models;
using FluentValidation;

namespace TraineeShop.Validation
{
    public class CarValidation:AbstractValidator<Car>
    {
        public CarValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Имя должно быть").MaximumLength(20).WithMessage("Имя должно быть меньше 20 символов");
            RuleFor(x => x.Description).MaximumLength(200).WithMessage("Длина описания должна быть меньше 200");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Цена должна быть").GreaterThan(0).WithMessage("Цена должна быть больше 0").LessThan(10000000).WithMessage("Цена должна быть меньше 10000000");
            RuleFor(x => x.Picture).NotEmpty().WithMessage("Картинка должна быть");
        }
    }
}
