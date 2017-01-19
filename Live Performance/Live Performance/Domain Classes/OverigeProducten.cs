using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Domain_Classes
{
    public class OverigeProducten:Producten
    {
        public bool Alcohol { get; set; }
        public decimal Inkoop { get; set; }

        public OverigeProducten()
        {
            
        }
        public OverigeProducten(string naam, bool alcohol, decimal verkoop,int id) : base(naam,verkoop,id)
        {
            Alcohol = alcohol;
        }
    }
}
