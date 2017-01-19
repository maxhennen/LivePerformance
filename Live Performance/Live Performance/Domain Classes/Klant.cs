using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Domain_Classes
{
    public class Klant
    {
        public int KlantNummer { get; set; }
        public string Naam { get; set; }
        public string Adres { get; set; }

        public Klant(int klantnummer)
        {
            KlantNummer = klantnummer;
        }

        public Klant(string naam, string adres)
        {
            Naam = naam;
            Adres = adres;
        }
    }
}
