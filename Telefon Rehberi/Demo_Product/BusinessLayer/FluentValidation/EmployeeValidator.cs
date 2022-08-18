using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.FluentValidation
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        // Fluent Validation ile her entity için class oluşturup kısıtlamalar getirdik.
        public EmployeeValidator()
        {
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir Bilgisi boş geçilemez");
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim boş geçilemez");
            RuleFor(x => x.PhoneNo).NotEmpty().WithMessage("Telefon rehberinde kişilerin telefon numarası kayıtlı olmak zorundadır.");
        }
    }
}
