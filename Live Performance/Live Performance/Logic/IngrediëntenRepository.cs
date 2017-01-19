using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Domain_Classes;
using Live_Performance.Interfaces;

namespace Live_Performance.Logic
{
    public class IngrediëntenRepository
    {
        private IIngrediëntenSQLContext Context;
        private ITestInterface TestContext;
        public IngrediëntenRepository(IIngrediëntenSQLContext context)
        {
            Context = context;
        }

        public IngrediëntenRepository(ITestInterface test)
        {
            TestContext = test;
        }

        public List<Ingrediënten> IngrediëntenBijPizza(string naam, int formaat)
        {
            return Context.IngrediëntenBijPizza(naam, formaat);
        }

        public List<Ingrediënten> AlleIngrediënten()
        {
            return Context.AlleIngrediënten();
        }

        public Ingrediënten BodemBijPizza(string bodem)
        {
            return Context.BodemBijPizza(bodem);
        }

        public List<Ingrediënten> TestIngrediënten()
        {
            return TestContext.Ingrediënten();
        }

        public Ingrediënten TestBodemBijPizza(string bodem)
        {
            return TestContext.Bodem(bodem);
        }

    }
}
