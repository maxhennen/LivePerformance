using Microsoft.VisualStudio.TestTools.UnitTesting;
using Live_Performance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Data;
using Live_Performance.Domain_Classes;
using Live_Performance.Logic;

namespace Live_Performance.Tests
{
    [TestClass()]
    public class PizzeriaTests
    {
        [TestMethod()]
        public void btnPizzaOpslaan_ClickTest()
        {
            IngrediëntenRepository ingrediëntenRepo = new IngrediëntenRepository(new TestData());
            List<Ingrediënten> Ingrediënten = new List<Ingrediënten>();
            List<Producten> ProductenListBox = new List<Producten>();
            foreach (var item in ingrediëntenRepo.TestIngrediënten())
            {
                Ingrediënten ingrediënt = new Ingrediënten(item.Naam,item.Verkoop,item.Veganistisch,item.Halal);
                Ingrediënten.Add(ingrediënt);
                Ingrediënten.Add(ingrediëntenRepo.TestBodemBijPizza("Dunne"));
            }
            Producten p = new Pizza();
            Producten pizza = new Pizza("CustomPizza",p.PrijsBepalen(Ingrediënten,50),50,"Rond","Dun",false,0);
            ProductenListBox.Add(pizza);
            Assert.AreEqual(1,ProductenListBox.Count);
        }
    }
}

