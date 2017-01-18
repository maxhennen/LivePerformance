using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Domain_Classes
{
    public class Klant
    {
        public int KlantNummer { get; private set; }
        public string Naam { get; private set; }
        public string Adres { get; private set; }

        public Klant(int klantNummer, string naam, string adres)
        {
            KlantNummer = klantNummer;
            Naam = naam;
            Adres = adres;
        }
    }
}
