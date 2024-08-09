using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeMax.Business.Entity;
using CafeMax.DataAccess.database;
using CafeMax.DataAccess.orderdetail;
using Microsoft.Data.SqlClient;

namespace CafeMax.DataAccess.sale
{
    class SaleManager : ISale
    {
        public IDatabase database;

        public SaleManager() { database = new MsSqlDatabase(); }
        public bool AddDiscount(Guid saleCode, decimal discount)
        {
            int result = 0;
            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Update sale Set discount = @discount Where code = @saleCode";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@discount", discount);
                    command.Parameters.AddWithValue("@saleCode", saleCode);

                    result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public bool AddSale(string tableName)
        {
            int result = 0; 
            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Insert Into [sale] (code, date, status, order_id, discount, total_paid, total_price) " +
                    "values('INV-' + Convert(Varchar(36), NEWID()), GETDATE(), 1, (Select id From [order] Where table_name = @tableName and status = 1), 0, 0, 0)";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tableName", tableName);

                    result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public bool AddTotalPaid(Guid saleCode, decimal paid)
        {
            int result = 0;
            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Update sale Set total_paid += @paid Where code = @saleCode";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@paid", paid);
                    command.Parameters.AddWithValue("@saleCode", saleCode);

                    result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public bool AddTotalPrice(string tableName, decimal price)
        {
            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Update sale Set total_price += @price Where order_id = (Select id From [order] Where table_name = @tableName and status = 1)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@tableName", tableName);

                    command.ExecuteNonQuery();

                }
                return true;
            }
            
        }

        

        public List<Sale> GetAll()
        {
            List<Sale> sales = new List<Sale>();

            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select sale.id as id, sale.code as code, [order].table_name as table_name, sale.discount as discount, sale.total_price as total_price, sale.date as date, sale.total_paid as total_paid, sale.status as status " +
                    "From sale inner join [order] on [order].id = sale.order_id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Sale sale = new Sale();

                            sale.Id = (int)reader["id"];
                            sale.Code = (Guid)reader["code"];
                            sale.TableName = (string)reader["table_name"];
                            sale.Discount = (decimal)reader["discount"];
                            sale.TotalPrice = (decimal)reader["total_price"];
                            sale.Date = (DateTime)reader["date"];
                            sale.TotalPaid = (decimal)reader["total_paid"];
                            sale.Status = (bool)reader["status"];

                            sales.Add(sale);
                        }
                        connection.Close();
                    }
                }
            }

            return sales;
        }

        public List<Sale> GetOpenSales()
        {
            List<Sale> sales = new List<Sale>();


            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select sale.id, sale.code, sale.discount, sale.total_price, sale.date, sale.total_paid, sale.status, [order].table_name From sale Inner Join [order] on [order].id = sale.order_id Where sale.status = 1";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Sale sale = new Sale();

                        sale.Id = (int)reader["id"];
                        sale.Code = (Guid)reader["code"];
                        sale.Discount = (decimal)reader["discount"];
                        sale.TotalPrice = (decimal)reader["total_price"];
                        sale.Date = (DateTime)reader["date"];
                        sale.TotalPaid = (decimal)reader["total_paid"];
                        sale.Status = (bool)reader["status"];
                        sale.TableName = (string)reader["table_name"];

                        sales.Add(sale);
                    }
                }

            }

            return sales;
        }

        public Sale GetSaleByOrderId(Guid orderCode)
        {
            Sale sale = new Sale();

            using (var connection = database.GetConnection())
            {
                connection.Open();
                
                string query = "Select * From sale Where order_id = (Select id From [order] Where code = @orderCode)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@orderCode", orderCode);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                        sale.Id = (int)reader["id"];
                        sale.Code = (Guid)reader["code"];
                        sale.Discount = (decimal)reader["discount"];
                        sale.TotalPrice = (decimal)reader["total_price"];
                        sale.Date = (DateTime)reader["date"];
                        sale.TotalPaid = (decimal)reader["total_paid"];
                        sale.Status = (bool)reader["status"];
                        
                    }
                }

            }

            return sale;
        }

        public Sale GetSaleByTableName(string tableName)
        {
            Sale sale = new Sale();

            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select * From sale Where order_id = (Select id From [order] Where table_name = @tableName and status = 1)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tableName", tableName);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                        sale.Id = (int)reader["id"];
                        sale.Code = (Guid)reader["code"];
                        sale.Discount = (decimal)reader["discount"];
                        sale.TotalPrice = (decimal)reader["total_price"];
                        sale.Date = (DateTime)reader["date"];
                        sale.TotalPaid = (decimal)reader["total_paid"];
                        sale.Status = (bool)reader["status"];

                    }
                }

            }

            return sale;
        }

        public List<Sale> GetSalesByDate(DateTime firstDate, DateTime secondDate)
        {
            List<Sale> sales = new List<Sale>();

            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select sale.id as id, sale.code as code, [order].table_name as table_name, sale.discount as discount, sale.total_price as total_price, sale.date as date, sale.total_paid as total_paid, sale.status as status From sale inner join [order] on [order].id = sale.order_id Where sale.[date] between @firstDate and @secondDate";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@firstDate", firstDate);
                    command.Parameters.AddWithValue("@secondDate", secondDate);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Sale sale = new Sale();

                            sale.Id = (int)reader["id"];
                            sale.Code = (Guid)reader["code"];
                            sale.TableName = (string)reader["table_name"];
                            sale.Discount = (decimal)reader["discount"];
                            sale.TotalPrice = (decimal)reader["total_price"];
                            sale.Date = (DateTime)reader["date"];
                            sale.TotalPaid = (decimal)reader["total_paid"];
                            sale.Status = (bool)reader["status"];

                            sales.Add(sale);
                        }
                        connection.Close();
                    }
                }
            }

            return sales;
        }
    }
}
