using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Data;
using Live_Performance.Logic;

namespace Live_Performance.Domain_Classes
{
    public class Pizza:Producten
    {
        public  decimal Formaat { get; set; }
        public string Vorm { get; set; }
        public  string Soort { get; set; }
        public bool Gluten { get; set; }
        public  List<Ingrediënten> Ingrediënten { get; set; }

        public Pizza()
        {
            
        }
        public Pizza(string naam,decimal verkoopprijs,decimal formaat, string vorm, string soort, bool gluten,int id) : base(naam,verkoopprijs,id)
        {
            Formaat = formaat;
            Vorm = vorm;
            Soort = soort;
            Gluten = gluten;
        }
    }
}
