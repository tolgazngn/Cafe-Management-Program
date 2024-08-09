using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeMax.DataAccess.database;
using Microsoft.Data.SqlClient;

namespace CafeMax.DataAccess.authentication
{
    class AuthenticationManager : IAuthentication
    {
        IDatabase database = new MsSqlDatabase();

        public bool LoginUser(string username, string password)
        {
            
            using (SqlConnection connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select username From [user] Where username = @username and password = @password";

                
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    

                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["username"] != null) { return true; }
                        }
                    }
                }

            }
            return false;
        }
    }
}
