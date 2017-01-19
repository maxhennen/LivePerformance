using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Domain_Classes;
using Live_Performance.Interfaces;

namespace Live_Performance.Data
{
    public class BestellingSQLContext : IBestellingSQLContext
    {
        public void BestellingToevoegen(Klant klant, List<Producten> producten)
        {
            decimal totaalprijs = 0;
            foreach (var product in producten)
            {
                totaalprijs = totaalprijs + product.Verkoopprijs;
            }
            string queryKlant = "INSERT INTO Klant(Naam,Adres)values(@Naam,@Adres)";
            string queryBestelling =
                "INSERT INTO Bestelling(DatumTijd,TotaalPrijs,KlantNummer)values(@DatumTijd,@TotaalPrijs,@Klantnummer)";
            string queryBestelregel =
                "INSERT INTO Bestelregel(PizzaID,BestellingID,OverigeProductenID)values(@PizzaID,(Select MAX(BestellingID)From Bestelling),@OverigeProductenID);";
            using (SqlConnection conn = Database.Connection)
            {
                SqlCommand cmd;
                if (klant.Adres != null)
                {
                    cmd = new SqlCommand(queryKlant, conn);
                    cmd.Parameters.Add("@Naam", klant.Naam);
                    cmd.Parameters.Add("@Adres", klant.Adres);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand(queryBestelling, conn);
                    cmd.Parameters.AddWithValue("@DatumTijd", DateTime.Now);
                    cmd.Parameters.AddWithValue("@TotaalPrijs", totaalprijs);
                    cmd.Parameters.AddWithValue("@Klantnummer", DBNull.Value);
                    cmd.ExecuteNonQuery();
                }

                else if (klant.Adres == null && klant.KlantNummer != null)
                {

                    cmd = new SqlCommand(queryBestelling, conn);
                    cmd.Parameters.AddWithValue("@DatumTijd", DateTime.Now);
                    cmd.Parameters.AddWithValue("@TotaalPrijs", totaalprijs);
                    cmd.Parameters.AddWithValue("@Klantnummer", klant.KlantNummer);
                    cmd.ExecuteNonQuery();
                }
                foreach (var item in producten)
                {
                    try
                    {
                        cmd = new SqlCommand(queryBestelregel, conn);
                        cmd.Parameters.AddWithValue("@PizzaID", item.ID);
                        cmd.Parameters.AddWithValue("@OverigeProductenID", DBNull.Value);
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException)
                    {
                        cmd = new SqlCommand();
                    }
                    

                   //cmd = new SqlCommand(queryBestelregel, conn);
                   //cmd.Parameters.AddWithValue("@PizzaID", DBNull.Value);
                   //cmd.Parameters.AddWithValue("@OverigeProductenID", item.ID);
                   //cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
