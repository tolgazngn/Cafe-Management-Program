using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeMax.Business.Entity;
using CafeMax.DataAccess.database;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CafeMax.DataAccess.product
{
    class ProductManager : IProduct
    {
        public IDatabase database;

        public ProductManager() { database = new MsSqlDatabase(); }

        public bool AddProduct(Product product)
        {
            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Insert Into product (name, unit_price, menu_id, stock) " +
                    "Values(@name, @unitPrice, (Select id From menu_ Where name = @menuName), 0)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", product.Name);
                    command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
                    command.Parameters.AddWithValue("@menuName", product.Menu);

                    int result = command.ExecuteNonQuery();

                    return result > 0;
                }
            }
        }

        public bool ChangeStock(string productName, short stock)
        {
            throw new NotImplementedException();
        }

        public bool ChangeUnitPrice(string productName, decimal unitPrice)
        {
            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Update product Set unit_price = @unitPrice Where name = @productName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@unitPrice", unitPrice);
                    command.Parameters.AddWithValue("@productName", productName);

                    int result = command.ExecuteNonQuery();

                    return result > 0;
                }

            }
        }

        public bool DeleteProduct(string productName)
        {
            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Delete From product Where name = @productName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@productName", productName);

                    int result = command.ExecuteNonQuery();

                    return result > 0;
                }
            }
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetUnitPriceByName(string productName)
        {
            Product product = new Product();

            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select unit_price From product Where name = @productName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@productName", productName);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                        product.UnitPrice = (decimal)reader["unit_price"];

                    }
                }

            }

            return product;
        }

        public List<Product> GetProductsByMenu(string menuName)
        {
            List<Product> products = new List<Product>();


            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select product.id, product.name, product.unit_price, menu_.name as menu_name, product.stock, product.description " +
                    "From product Inner Join menu_ on menu_.id = product.menu_id " +
                    "Where menu_id = (Select id From menu_ Where name = @menuName)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@menuName", menuName);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Product product = new Product();

                        product.Id = (int)reader["id"];
                        product.Name = (string)reader["name"];
                        product.UnitPrice = (decimal)reader["unit_price"];
                        product.Menu = (string)reader["menu_name"];
                        product.Stock = (int)reader["stock"];

                        if(reader["description"] != DBNull.Value) { product.Description = (string)reader["description"]; }
                        
                        products.Add(product);
                    }
                }

            }

            return products;
        }

        public bool AddStock(string productName, short value)
        {
            int result = 0;

            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Update product Set stock += @value Where name = @productName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@value", value);
                    command.Parameters.AddWithValue("@productName", productName);
                    
                    result = command.ExecuteNonQuery();

                    return result > 0;
                }

            }
        }

        public bool CheckProductNameAvailability(string productName)
        {
            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select id From product Where name = @productName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@productName", productName);

                    int result = command.ExecuteNonQuery();

                    return result > 0;
                }
            }
        }
    }
}
