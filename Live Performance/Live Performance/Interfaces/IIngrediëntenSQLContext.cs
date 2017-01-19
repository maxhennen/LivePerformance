using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Domain_Classes;

namespace Live_Performance.Interfaces
{
    public interface IIngrediëntenSQLContext
    {
        List<Ingrediënten> IngrediëntenBijPizza(string naam, int formaat);
        List<Ingrediënten> AlleIngrediënten();
        Ingrediënten BodemBijPizza(string bodem);
    }
}
