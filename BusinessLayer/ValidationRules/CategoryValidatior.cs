using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidatior: AbstractValidator<Category>
    {
        public CategoryValidatior()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Kategori Adını Boş Geçemezsiniz.!");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklamayı Boş Geçemezsiniz.!");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("En az 3 karakter girişi yapınız.!");
            RuleFor(x => x.Name).MaximumLength(20).WithMessage("20 Karakterden fazla değer girişi yapmayın.!");
        }
    }
}
