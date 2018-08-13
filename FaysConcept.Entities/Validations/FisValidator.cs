using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Validators;
using FluentValidation;
using FaysConcept.Entities.Tables;

namespace FaysConcept.Entities.Validations
{
   public class FisValidator:AbstractValidator<Fis>
    {
        public FisValidator()
        {
                
        }
    }
}
