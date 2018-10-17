using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace FaysConcept.Entities.Tables
{
    public class CariBakiye
    {
        public string CariKodu { get; set; }
        public decimal RiskLimiti { get; set; } 
        public decimal Alacak { get; set; }
        public decimal Borc { get; set; }
        public decimal Bakiye { get; set; }

    }
}
