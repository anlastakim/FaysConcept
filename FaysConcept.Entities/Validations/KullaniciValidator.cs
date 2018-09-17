using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaysConcept.Entities.Tables;
using FluentValidation;
using FluentValidation.Validators;

namespace FaysConcept.Entities.Validations
{
   public class KullaniciValidator:AbstractValidator<Kullanici>
    {
        public KullaniciValidator()
        {
            RuleFor(p => p.KullaniciAdi).NotEmpty().WithMessage("Kullanıcı Adı alanı boş geçilemez");
            RuleFor(p => p.Parola).NotEmpty().WithMessage("Parola alanı boş geçilemez");
            RuleFor(p => p.Adi).NotEmpty().WithMessage("Adı alanı boş geçilemez");
            RuleFor(p => p.Soyadi).NotEmpty().WithMessage("Soyadı alanı boş geçilemez");
            RuleFor(p => p.Cevap).NotEmpty().WithMessage("Cevap alanı boş geçilemez");
        }
    }
}
