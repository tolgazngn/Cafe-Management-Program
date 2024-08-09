using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeMax.Business.Entity;
using CafeMax.DataAccess.database;
using CafeMax.DataAccess.table;
using Microsoft.Data.SqlClient;

namespace CafeMax.DataAccess.order
{
    class OrderManager : IOrder
    {
        public IDatabase database;

        public OrderManager(){database = new MsSqlDatabase();}

        public void AddOrder(string tableName)
        {
            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Insert Into [order] (code, table_name, date, status) " +
                    "values(NEWID(), @tableName, GETDATE(), 1)";

                string query2 = "Update table_ Set is_busy = 1 Where name = @tableName";



                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tableName", tableName);

                    int result = command.ExecuteNonQuery();
                }

                using (SqlCommand command = new SqlCommand(query2, connection))
                {
                    command.Parameters.AddWithValue("@tableName", tableName);

                    int result = command.ExecuteNonQuery();
                }
            }
        }

        public List<Order> GetAll()
        {
            List<Order> orders = new List<Order>();

            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select * From [order]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Order order = new Order();

                            order.Id = (int)reader["id"];
                            order.Code = (Guid)reader["code"];
                            order.TableName = (string)reader["table_name"];
                            order.Date = (DateTime)reader["date"];
                            order.Status = (bool)reader["status"];

                            orders.Add(order);
                        }
                        connection.Close();
                    }
                }
            }

            return orders;
        }

        public List<Order> GetLastFiftyOrder()
        {
            List<Order> orders = new List<Order>();


            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select * From [order] Order By date DESC Offset 0 Rows Fetch Next 50 Rows Only";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Order order = new Order();

                        order.Id = (int)reader["id"];
                        order.Code = (Guid)reader["code"];
                        order.TableName = (string)reader["table_name"];
                        order.Date = (DateTime)reader["date"];
                        order.Status = (bool)reader["status"];

                        orders.Add(order);
                    }
                }
            }

            return orders;
        }

        public List<Order> GetOrdersByDate(DateTime firstDate, DateTime secondDate)
        {
            List<Order> orders = new List<Order>();

            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select * From [order] Where [order].[date] between @firstDate and @secondDate";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@firstDate", firstDate);
                    command.Parameters.AddWithValue("@secondDate", secondDate);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Order order = new Order();

                            order.Id = (int)reader["id"];
                            order.Code = (Guid)reader["code"];
                            order.TableName = (string)reader["table_name"];
                            order.Date = (DateTime)reader["date"];
                            order.Status = (bool)reader["status"];

                            orders.Add(order);
                        }
                        connection.Close();
                    }
                }
            }

            return orders;
        }

        public Order GetOrderByTableName(string tableName)
        {
            Order order = new Order();


            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select * From [order] Where table_name = @tableName and status = 1";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tableName", tableName);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        order.Id = (int)reader["id"];
                        order.Code = (Guid)reader["code"]; 
                        order.Date = (DateTime)reader["date"];
                        order.TableName = (string)reader["table_name"];
                        order.Status = (bool)reader["status"];
                    }
                }

            }

            return order;
        }

        public bool CloseOrder(Guid code)
        {

            int result = 0;
            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Update [order] Set status = 0 Where code = @code";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@code", code);

                    result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public List<Order> GetOpenOrders()
        {
            List<Order> orders = new List<Order>();


            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select * From [order] Where status = 1";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Order order = new Order();

                        order.Id = (int)reader["id"];
                        order.Code = (Guid)reader["code"];
                        order.TableName = (string)reader["table_name"];
                        order.Date = (DateTime)reader["date"];
                        order.Status = (bool)reader["status"];


                        orders.Add(order);
                    }
                }
            }

            return orders;
        }
    }
}
