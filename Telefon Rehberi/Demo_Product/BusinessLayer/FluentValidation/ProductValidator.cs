using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        // Fluent Validation ile her entity için class oluşturup kısıtlamalar getirdik.
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ürün adını boş geçemezsiniz!");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Ürün adı minimum 3 karakter olmalıdır.");
            RuleFor(x => x.Stock).NotEmpty().WithMessage("Stok sayısı boş geçilemez!");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Ürün Fiyatı boş geçilemez!");

        }
    }
}
