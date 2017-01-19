using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Domain_Classes;

namespace Live_Performance.Interfaces
{
    public interface IProductenSQLContext
    {
        List<Pizza> AlleStandaardPizza();
        List<OverigeProducten> AlleOverigeProducten();
        void AanpassenPizza(Pizza pizza);
    }
}
