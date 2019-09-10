using FluentValidation;
using System;
using System.Collections.Generic;
using TraineeShop.Models;

namespace TraineeShop.Validation
{
    
    public class CompanyValidation : AbstractValidator<Company>
    {
        public CompanyValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Имя должно быть").MaximumLength(20).WithMessage("Имя должно быть меньше 20");
            RuleFor(x => x.Country).NotEmpty().WithMessage("Страна должна быть").MaximumLength(20).WithMessage("Название страны должно быть меньше 20");
        }
    }
}
