using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Live_Performance.Data;
using Live_Performance.Logic;

namespace Live_Performance.Domain_Classes
{
    public  abstract class Producten:IComparable<Producten>
    {
        public  string Naam { get; set; }
        public decimal Verkoopprijs { get; set; }
        public int ID { get; set; }
        private ProductenRepository ProductenRepo;
        public Producten()
        {
            
        }
        public Producten(string naam,decimal verkoopprijs,int id)
        {
            Naam = naam;
            Verkoopprijs = verkoopprijs;
            ID = id;
        }


        public List<Pizza> AlleStandaardPizza()
        {
            ProductenRepo = new ProductenRepository(new ProductenSQLContext());
            return ProductenRepo.AlleStandaardPizza();
        }

        public List<OverigeProducten> AllOverigeProducten()
        {
            ProductenRepo = new ProductenRepository(new ProductenSQLContext());
            return ProductenRepo.AlleOverigeProducten();
        }

        public decimal PrijsBepalen(List<Ingrediënten> ingrediënten, decimal formaat)
        {
            decimal Prijs = 0;
            foreach (var ingrediënt in ingrediënten)
            {
                Prijs = Prijs + ingrediënt.Verkoop * formaat ;
            }
            return Prijs/100;
        }

        public decimal RondOppervlakBerekenen(int diameter)
        {
            return  Convert.ToDecimal(0.25) * Convert.ToDecimal(Math.PI) * diameter * diameter;
        }

        public decimal VierkantOppervlakBereken(int lengte, int breedte)
        {
            return  lengte * breedte;
        }

        public decimal DrieHoekBerekenen(int lengte, int breedte, int diepte)
        {
            decimal tijdelijkeVar = (lengte + breedte + diepte) / 2;
            decimal berekening = tijdelijkeVar * (tijdelijkeVar - lengte) * (tijdelijkeVar - breedte) * (tijdelijkeVar - diepte);
            return Convert.ToDecimal(Math.Sqrt(Convert.ToDouble(berekening)));
        }

        public int CompareTo(Producten other)
        {
            return Naam.CompareTo(other.Naam);
        }

        public void AanpassenPizza(Pizza pizza)
        {
            ProductenRepo = new ProductenRepository(new ProductenSQLContext());
            ProductenRepo.AanpassenPizza(pizza);
        }
    }
}
