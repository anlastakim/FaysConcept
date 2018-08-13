using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaysConcept.Entities.Context;
using FaysConcept.Entities.Repositories;
using FaysConcept.Entities.Tables;
using FaysConcept.Entities.Validations;

namespace FaysConcept.Entities.DataAccess
{
   public class KasaHareketDAL : EntityRepositoryBase<FaysConceptContext, KasaHareket,KasaHareketValidator>
    {
    }
}
