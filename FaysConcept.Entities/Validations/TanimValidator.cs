using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FaysConcept.Entities.Tables;

namespace FaysConcept.Entities.Validations
{
   public class TanimValidator:AbstractValidator<Tanim>
    {
        public TanimValidator()
        {
            RuleFor(p => p.Turu).NotEmpty().WithMessage("Tanim Türü alanı boş geçilemez");
            RuleFor(p => p.Tanimi).NotEmpty().WithMessage("Tanim alanı boş geçilemez");
        }
    }
}
