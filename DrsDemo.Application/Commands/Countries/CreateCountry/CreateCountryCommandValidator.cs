using DrsDemo.Domain;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrsDemo.Application.Commands.Countries.CreateCountry
{
    public class CreateCountryCommandValidator : AbstractValidator<CreateCountry>
    {
        public CreateCountryCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Ülke adı boş geçilemez.")
                .NotNull().WithMessage("Ülke adı boş geçilemez")
                .MaximumLength(CountryConst.NameMaxLength).WithMessage($"Ülke adı {CountryConst.NameMaxLength} karakteri geçemez.");
        }
    }
}
