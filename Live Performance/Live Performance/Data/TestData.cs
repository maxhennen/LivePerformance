using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Domain_Classes;
using Live_Performance.Interfaces;

namespace Live_Performance.Data
{
    public class TestData:ITestInterface
    {
        public List<Ingrediënten> Ingrediënten()
        {
            List<Ingrediënten> Ingrediënts = new List<Ingrediënten>();
            for (int i = 0; i < 10; i++)
            {
                Ingrediënten ingrediënt = new Ingrediënten("ingrediënt"+1,Convert.ToDecimal(0.25 * i),false,false);
                Ingrediënts.Add(ingrediënt);
            }
            return Ingrediënts;
        }

        public Ingrediënten Bodem(string bodem)
        {
            List<Ingrediënten> Ingrediënts = new List<Ingrediënten>();
            Ingrediënten dikke = new Ingrediënten("Dikke bodem",Convert.ToDecimal(1.20),true,true);
            Ingrediënten dunne = new Ingrediënten("Dunne bodem", Convert.ToDecimal(0.80), true, true);
            Ingrediënts.Add(dikke);
            Ingrediënts.Add(dunne);

            for (int i = 0; i < Ingrediënts.Count; i++)
            {
                if (Ingrediënts[1].Naam.Contains(bodem))
                {
                    return Ingrediënts[i];
                }
            }
            return null;
        }
    }
}
