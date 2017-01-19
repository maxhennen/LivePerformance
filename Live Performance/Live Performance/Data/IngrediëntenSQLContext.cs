using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Domain_Classes;
using Live_Performance.Interfaces;

namespace Live_Performance.Data
{
    public class IngrediëntenSQLContext:IIngrediëntenSQLContext
    {
        private List<Ingrediënten> IngrediëntenList;
        public List<Ingrediënten> IngrediëntenBijPizza(string naam, int formaat)
        {
            IngrediëntenList = new List<Ingrediënten>();
            using (SqlConnection conn = Database.Connection)
            {
                string query = "select i.* from Ingrediënten i join PizzaIngrediënten pzi on pzi.IngrediëntenID = i.IngrediëntenID join Pizza p on p.PizzaID = pzi.PizzaID where p.Naam like @Naam and p.Formaat = @Formaat;";
                SqlCommand cmd = new SqlCommand(query,conn);
                cmd.Parameters.AddWithValue("@Naam", naam);
                cmd.Parameters.AddWithValue("@Formaat", formaat);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    IngrediëntenList.Add(CreateIngrediëntFromReader(reader));
                }
            }
            return IngrediëntenList;
        }

        public List<Ingrediënten> AlleIngrediënten()
        {
            IngrediëntenList = new List<Ingrediënten>();
            using (SqlConnection conn = Database.Connection)
            {
                string query = "Select * FROM Ingrediënten";
                SqlCommand cmd = new SqlCommand(query,conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    IngrediëntenList.Add(CreateIngrediëntFromReader(reader));
                }
            }
            return IngrediëntenList;
        }

        public Ingrediënten BodemBijPizza(string bodem)
        {
            Ingrediënten ingrediënt = new Ingrediënten();
            using (SqlConnection conn = Database.Connection)
            {
                string query = "select * from Ingrediënten where Naam like '%'+ @Bodem +'%';";
                SqlCommand cmd = new SqlCommand(query,conn);
                cmd.Parameters.AddWithValue("@Bodem", "%"+bodem+"%");
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ingrediënt = CreateIngrediëntFromReader(reader);
                }
            }
            return ingrediënt;
        }

        public Ingrediënten CreateIngrediëntFromReader(SqlDataReader reader)
        {
            return new Ingrediënten(
                Convert.ToString(reader["Naam"]),
                Convert.ToDecimal(reader["Verkoop"]),
                Convert.ToBoolean(reader["Veganistisch"]),
                Convert.ToBoolean(reader["Halal"]));
        }
    }
}
