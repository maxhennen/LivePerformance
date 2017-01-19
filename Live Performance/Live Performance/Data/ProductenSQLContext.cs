using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Live_Performance.Domain_Classes;
using Live_Performance.Interfaces;

namespace Live_Performance.Data
{
    public class ProductenSQLContext:IProductenSQLContext
    {
        private List<Pizza> PizzaList;
        private List<OverigeProducten> OverigeProductenList;

        public List<Pizza> AlleStandaardPizza()
        {
            PizzaList = new List<Pizza>();
            using (SqlConnection conn = Database.Connection)
            {
                string query = "select p.*, Sum(i.Verkoop) as Prijs from Pizza p join PizzaIngrediënten pzi on pzi.PizzaID = p.PizzaID join Ingrediënten i on i.IngrediëntenID = pzi.IngrediëntenID where p.Soort like 'Standaard' group by p.PizzaID,p.Formaat,p.Naam,p.Soort,p.Vorm, p.Gluten;";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                    PizzaList.Add(CreatePizzaFromReader(reader));
                    }
            }
            return PizzaList;
        }

        public List<OverigeProducten> AlleOverigeProducten()
        {
            OverigeProductenList = new List<OverigeProducten>();
            using (SqlConnection conn = Database.Connection)
            {
                string query = "Select * From OverigeProducten";
                SqlCommand cmd = new SqlCommand(query,conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    OverigeProductenList.Add(CreateOverigProductFromReader(reader));
                }
            }
            return OverigeProductenList;
        }

        public void AanpassenPizza(Pizza product)
        {
            using (SqlConnection conn = Database.Connection)
            {
                string query = "Update Pizza Set Naam = @Naam, Formaat = @Formaat, Vorm = @Vorm, Soort = @Soort, Gluten = @Gluten where PizzaID = @PizzaID";
                SqlCommand cmd = new SqlCommand(query,conn);
                SqlDataReader reader = cmd.ExecuteReader();
                cmd.Parameters.AddWithValue("@Naam", product.Naam);
                cmd.Parameters.AddWithValue("@Formaat", product.Formaat);
                cmd.Parameters.AddWithValue("@Vorm", product.Vorm);
                cmd.Parameters.AddWithValue("@Soort", product.Soort);
                cmd.Parameters.AddWithValue("@Gluten", product.Gluten);
                cmd.ExecuteNonQuery();
            }
        }

        public Pizza CreatePizzaFromReader(SqlDataReader reader)
        {
            return new Pizza(
                Convert.ToString(reader["Naam"]),
                Convert.ToDecimal(reader["Prijs"]),
                Convert.ToInt32(reader["Formaat"]),
                Convert.ToString(reader["Vorm"]),
                Convert.ToString(reader["Soort"]),
                Convert.ToBoolean(reader["Gluten"]),
                Convert.ToInt32(reader["PizzaID"]));
        }

        public OverigeProducten CreateOverigProductFromReader(SqlDataReader reader)
        {
            return new OverigeProducten(
                Convert.ToString(reader["Naam"]),
                Convert.ToBoolean(reader["Alcoholisch"]),
                Convert.ToDecimal(reader["Verkoop"]),
                Convert.ToInt32(reader["ProductID"]));
        }
    }
}
