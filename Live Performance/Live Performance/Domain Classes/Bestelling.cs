using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Data;
using Live_Performance.Logic;

namespace Live_Performance.Domain_Classes
{
    public class Bestelling
    {
        private BestellingRepository BestellingRepo;
        public Bestelling()
        {
            
        }
       public void BestellingToevoegen(Klant klant, List<Producten> producten )
       {
           BestellingRepo = new BestellingRepository(new BestellingSQLContext());
           BestellingRepo.BestellingToevoegen(klant,producten);
       }
    }
}
