using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace CafeMax.DataAccess.database
{
    class MsSqlDatabase : IDatabase
    {
        private static string connectionString;
        private SqlConnection connection;

        public MsSqlDatabase()
        {
            //connectionString = GetConnectionString();
            connectionString = "Data Source=DESKTOP-H7FNLL7;Initial Catalog=cafemax;Integrated Security=True;Trust Server Certificate=True";
            connection = new SqlConnection(connectionString);
        }

        public void CloseConnection()
        {
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void OpenConnection()
        {
            try
            {
                connection.Open();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        
        public SqlConnection GetConnection() { return this.connection; }

        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        }
    }
}
