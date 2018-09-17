using FaysConcept.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaysConcept.Entities.Tables
{
  public  class KodUret:IEntity
    {
        public int Id { get; set; }
        public string Tablo { get; set; }
        public string OnEki { get; set; }
        public int SonDeger { get; set; }
    }
}
