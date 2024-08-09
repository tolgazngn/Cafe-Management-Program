using CafeMax.Business.Entity;
using CafeMax.DataAccess.database;
using CafeMax.DataAccess.table;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CafeMax.DataAccess.user
{
    class UserManager : IUser
    {
        public IDatabase database;

        public UserManager() { database = new MsSqlDatabase(); }

        public bool AddUser(User user)
        {
            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Insert Into [user] (id, username, password, date_of_registration) " +
                    "Values(@id, @username, @password, GETDATE())";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", user.Id);
                    command.Parameters.AddWithValue("@username", user.Username);
                    command.Parameters.AddWithValue("@password", user.Password);

                    int result = command.ExecuteNonQuery();

                    return result > 0;
                }
            }
        }

        public bool ChangePassword(string username, string password)
        {
            int result = 0;

            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Update [user] Set password = @password Where username = @username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@username", username);

                    result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public bool ChangeUsername(string username, string newUsername)
        {
            int result = 0;

            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Update [user] Set username = @newUsername Where username = @username";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@newUsername", newUsername);
                    command.Parameters.AddWithValue("@username", username);

                    result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public bool CheckUsernameAvailability(string username)
        {
            int result = 0;

            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select username From [user] Where username = @username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    result = command.ExecuteNonQuery();

                    return result > 0;
                }
            }
        }

        public bool DeleteUser(string username)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(int id)
        {
            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Delete From [user] Where id = @id and id != 10";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    int result = command.ExecuteNonQuery();

                    return result > 0;
                }
            }
        }

        public List<User> GetAll()
        {
            List<User> users = new List<User>();

            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select id, username, date_of_registration From [user] Where id != 10";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        User user = new User();

                        user.Id = (int)reader["id"];
                        user.Username = (string)reader["username"];

                        if (reader["date_of_registration"] != DBNull.Value) { user.DateOfRegistration = (DateTime)reader["date_of_registration"]; }
                        
                        users.Add(user);
                    }

                    return users;
                }

            }
        }

        public string GetPasswordByUsername(string username)
        {
            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select password From [user] Where username = @username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        return (string)reader["password"];
                    }
                }

            }

            return "";
        }
    }
}
