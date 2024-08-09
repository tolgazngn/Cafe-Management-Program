using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeMax.Business.Entity;
using CafeMax.DataAccess.database;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CafeMax.DataAccess.table
{
    class TableManager : ITable
    {
        public IDatabase database;

        public TableManager() { database = new MsSqlDatabase(); }

        public bool AddTable(string tableName)
        {
            int result = 0;
            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Insert Into table_ Values(@tableName, 0, 0)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tableName", tableName);

                    result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public bool ChangeBusyness(string tableName, bool busyness)
        {
            int result = 0;
            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Update table_ Set is_busy = @busyness Where name = @tableName";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    

                    command.Parameters.AddWithValue("@busyness", busyness);
                    command.Parameters.AddWithValue("@tableName", tableName);

                    result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public bool ChangeRezervation(string tableName, bool rezervation)
        {
            throw new NotImplementedException();
        }

        public bool CheckTableNameAvailability(string tableName)
        {
            int result = 0;
            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select name From table_ Where [name] = @tableName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tableName", tableName);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        result++;
                    }

                    return result > 0;
                }
            }

        }

        public bool DeleteTable(string tableName)
        {
            int result = 0;
            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Delete From table_ Where name = @tableName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tableName", tableName);

                    result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public List<Table> GetAll()
        {
            List<Table> tables = new List<Table>();


            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select * From table_";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Table table = new Table();

                        table.Id = (int)reader["id"];
                        table.Name = (string)reader["name"];
                        table.Status = (bool)reader["is_busy"];

                        tables.Add(table);
                    }
                }
                
            }

            return tables;
        }

        public List<Table> GetEmpties()
        {
            List<Table> tables = new List<Table>();


            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select name From table_ Where is_busy = 0";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Table table = new Table();
                        
                        table.Name = Convert.ToString(reader["name"]);
                        
                        tables.Add(table);
                    }
                }

            }

            return tables;
        }

        public List<Table> GetFulls()
        {
            List<Table> tables = new List<Table>();


            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select name From table_ Where is_busy = 1";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Table table = new Table();

                        table.Name = Convert.ToString(reader["name"]);

                        tables.Add(table);
                    }
                }

            }

            return tables;
        }

        public bool IsRowDeletable(string tableName)
        {
            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select is_busy From table_ Where [name] = @tableName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tableName", tableName);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        return (bool)reader["is_busy"];
                    }
                }
            }

            return false;
        }
    }
}
