using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Domain_Classes;
using Live_Performance.Interfaces;

namespace Live_Performance.Logic
{
    public class ProductenRepository
    {
        private IProductenSQLContext Context;

        public ProductenRepository(IProductenSQLContext context)
        {
            Context = context;
        }

        public List<Pizza> AlleStandaardPizza()
        {
            return Context.AlleStandaardPizza();
        }

        public List<OverigeProducten> AlleOverigeProducten()
        {
            return Context.AlleOverigeProducten();
        }

        public void AanpassenPizza(Pizza pizza)
        {
            Context.AanpassenPizza(pizza);
        }
    }
}
