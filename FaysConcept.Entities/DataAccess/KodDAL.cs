using FaysConcept.Entities.Context;
using FaysConcept.Entities.Repositories;
using FaysConcept.Entities.Tables;
using FaysConcept.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaysConcept.Entities.DataAccess
{
   public class KodDAL : EntityRepositoryBase<FaysConceptContext, KodUret, KodUretValidator>
    {
    }
}
