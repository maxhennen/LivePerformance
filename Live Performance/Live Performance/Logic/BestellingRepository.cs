using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Domain_Classes;
using Live_Performance.Interfaces;

namespace Live_Performance.Logic
{
    public class BestellingRepository
    {
        private IBestellingSQLContext Context;

        public BestellingRepository(IBestellingSQLContext context)
        {
            Context = context;
        }

        public void BestellingToevoegen(Klant klant, List<Producten> producten)
        {
            Context.BestellingToevoegen(klant,producten);
        }
    }
}
