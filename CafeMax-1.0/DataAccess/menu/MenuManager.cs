using CafeMax.Business.Entity;
using CafeMax.DataAccess.database;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.DataAccess.menu
{
    class MenuManager : IMenu
    {
        public IDatabase database;

        public MenuManager() { database = new MsSqlDatabase(); }

        public bool AddMenu(string menu)
        {
            throw new NotImplementedException();
        }

        public bool DeleteMenu(string menu)
        {
            throw new NotImplementedException();
        }

        public List<Menu> GetAll()
        {
            List<Menu> menus = new List<Menu>();


            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select * From menu_";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Menu menu = new Menu();

                        menu.Id = (int)reader["id"];
                        menu.Title = (string)reader["name"];

                        menus.Add(menu);
                    }
                }

            }

            return menus;
        }
    }
}
