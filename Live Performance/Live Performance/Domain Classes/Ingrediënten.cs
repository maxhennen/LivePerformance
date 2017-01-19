using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Data;
using Live_Performance.Logic;

namespace Live_Performance.Domain_Classes
{
    public class Ingrediënten
    {
        public  string Naam { get; set; }
        public  decimal Inkoop { get; set; }
        public  decimal Verkoop { get; set; }
        public  bool Veganistisch { get; set; }
        public bool Halal { get; set; }
        private IngrediëntenRepository IngrediëntenRepo;

        public Ingrediënten()
        {
            
        }
        public Ingrediënten(string naam,  decimal verkoop, bool veganistisch, bool halal)
        {
            Naam = naam;
            Verkoop = verkoop;
            Veganistisch = veganistisch;
            Halal = halal;
        }

        public List<Ingrediënten> IngrediëntenBijPizza(string pizzaNaam, int formaat)
        {
            IngrediëntenRepo = new IngrediëntenRepository(new IngrediëntenSQLContext());
            return IngrediëntenRepo.IngrediëntenBijPizza(pizzaNaam, formaat);
        }

        public List<Ingrediënten> AlleIngrediënten()
        {
            List<Ingrediënten> ingrediënten = new List<Ingrediënten>();
            IngrediëntenRepo = new IngrediëntenRepository(new IngrediëntenSQLContext());
            ingrediënten = ingrediënten = IngrediëntenRepo.AlleIngrediënten();
            foreach (var ingrediënt in ingrediënten.ToList())
            {
                if (ingrediënt.Naam == "Deeg voor dunne bodem" || ingrediënt.Naam == "Deeg voor dikke bodem" || ingrediënt.Naam == "Glutenvrije deegbodem")
                {
                    ingrediënten.Remove(ingrediënt);
                }
            }
            return ingrediënten;
        }

        public Ingrediënten BodemBijPizza(string bodem)
        {
            IngrediëntenRepo = new IngrediëntenRepository(new IngrediëntenSQLContext());
            return IngrediëntenRepo.BodemBijPizza(bodem);
        }
    }
}
