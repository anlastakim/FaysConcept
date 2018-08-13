using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaysConcept.Entities.Context;
using FaysConcept.Entities.Repositories;
using FaysConcept.Entities.Validations;
using FaysConcept.Entities.Tables;
using FluentValidation;

namespace FaysConcept.Entities.DataAccess
{
  public  class FisDAL : EntityRepositoryBase<FaysConceptContext, Fis,FisValidator>
    {

    }
}
