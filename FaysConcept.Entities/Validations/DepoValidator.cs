using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FaysConcept.Entities.Tables;
using FaysConcept.Entities.Context;

namespace FaysConcept.Entities.Validations
{
  public  class DepoValidator:AbstractValidator<Depo>
    {
        public DepoValidator()
        {
            RuleFor(p => p.DepoKodu).NotEmpty().WithMessage("Depo Kodu alanı boş geçilemez");
            RuleFor(p => p.DepoAdi).NotEmpty().WithMessage("Depo Adı alanı boş geçilemez");
            RuleFor(p => p.DepoKodu).Must(IsUnique).WithMessage("Bu depo koduna ait kayıt bulunmaktadır.");
        }

        private bool IsUnique(string arg)
        {
            using (var context=new FaysConceptContext())
            {
                return context.Depolar.Count(c => c.DepoKodu == arg) == 0;
            }
        }
    }

}
