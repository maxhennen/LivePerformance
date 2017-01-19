using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Data
{
    public class Database
    {
        private static string connectionString = "Server=mssql.fhict.local;Database=dbi358092;User Id=dbi358092;Password=Max2812LP;";
        public static SqlConnection Connection
        {
            get
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
        }
    }
}
