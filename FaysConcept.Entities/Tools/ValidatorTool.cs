using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaysConcept.Entities.Interface;
using FluentValidation;

namespace FaysConcept.Entities.Tools
{
   public static class ValidatorTool
    {
        public static bool Validate(IValidator validator,IEntity entity)
        //AbstractValidator dan validate edildiği için IValidator ile kullanılır.
        {
            bool result = true;

            var validationresult = validator.Validate(entity);
            if (!validationresult.IsValid) //! validate değilse anlamına gelir.
            {
                string message = null;
                foreach (var error in validationresult.Errors) // her bir hataya error diyoruz. validationresult bakılıyor.

                {
                    message += error.ErrorMessage+System.Environment.NewLine;

                }

                MessageBox.Show(message);
                result = false;

            }

            return result;
        }

    }
}
