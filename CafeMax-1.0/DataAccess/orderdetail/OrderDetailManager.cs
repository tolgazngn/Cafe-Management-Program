using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeMax.Business.Entity;
using CafeMax.DataAccess.database;
using Microsoft.Data.SqlClient;

namespace CafeMax.DataAccess.orderdetail
{
    class OrderDetailManager : IOrderDetail
    {
        public IDatabase database;

        public OrderDetailManager() { database = new MsSqlDatabase(); }
        public bool AddOrderDetail(OrderDetail orderDetail, string tableName)
        {
            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Begin Transaction; " +
                    "Insert Into order_detail (name, amount, unit_price, total_price, order_id) " +
                    "Values(@productName, @amount, (Select unit_price From [product] Where name = @productName), @amount * (Select unit_price From [product] Where name = @productName), (Select id From [order] Where table_name = @tableName and status = 1)); " +
                    "Update product Set stock -= @amount Where name = @productName; " +
                    "Commit;";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                     command.Parameters.AddWithValue("@productName", orderDetail.ProductName);
                     command.Parameters.AddWithValue("@amount", orderDetail.Amount);
                     command.Parameters.AddWithValue("@tableName", tableName);
                    

                    int result = command.ExecuteNonQuery();

                    if (result > 0) { return true; }
                    else { return false; }
                }

                
            }
        }

        public List<OrderDetail> GetOrderDetailsByCode(string ordercode)
        {
            throw new NotImplementedException();
        }

        public List<OrderDetail> GetOrderDetailsByOrderId(Guid orderCode)
        {
            List<OrderDetail> orderDetails = new List<OrderDetail>();


            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select * From order_detail Where order_id in (Select id From [order] Where code = @orderCode)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@orderCode", orderCode);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        OrderDetail orderDetail = new OrderDetail();

                        orderDetail.Id = (int)reader["id"];
                        orderDetail.ProductName = (string)reader["name"];
                        orderDetail.Amount = (int)reader["amount"];
                        orderDetail.TotalPrice = (decimal)reader["total_price"];
                        orderDetail.UnitPrice = (decimal)reader["unit_price"];

                        orderDetails.Add(orderDetail);

                    }
                }

            }

            return orderDetails;
        }

        public List<OrderDetail> GetOrderDetailsByTableName(string tableName)
        {
            List<OrderDetail> orderDetails = new List<OrderDetail>();


            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select * From order_detail Where order_id = (Select id From [order] Where table_name = @tableName and status = 1)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tableName", tableName);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        OrderDetail orderDetail = new OrderDetail();

                        orderDetail.Id = (int)reader["id"];
                        orderDetail.ProductName = (string)reader["name"];
                        orderDetail.Amount = (int)reader["amount"];
                        orderDetail.TotalPrice = (decimal)reader["total_price"];
                        orderDetail.UnitPrice = (decimal)reader["unit_price"];

                        orderDetails.Add(orderDetail);

                    }
                }

            }

            return orderDetails;
        }

        public decimal GetTotalPrice(string tableName)
        {
            throw new NotImplementedException();
        }

        
    }
}
