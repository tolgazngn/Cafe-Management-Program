using CafeMax.Business.Entity;
using CafeMax.DataAccess.database;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeMax.DataAccess.account
{
    internal class AccountManager : IAccount
    {
        private IDatabase database;

        public AccountManager() { database = new MsSqlDatabase(); }

        public bool AddDiscount(string tableName, decimal discount)
        {
            int result = 0;

            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Begin Transaction; " +
                    "Update [sale] Set discount = @discount Where order_id = (Select id From [order] Where table_name = @tableName and status = 1); " +
                    "Commit;";


                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@tableName", tableName);
                    command.Parameters.AddWithValue("@discount", discount);

                    result = command.ExecuteNonQuery();

                    return result > 0;
                }
            }
        }

        public bool CloseAccount(string tableName)
        {
            int result = 0;

            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Begin Transaction; Update sale Set status = 0 Where order_id = (Select id From [order] Where table_name = @tableName and status = 1); " +
                    "Update [order] Set status = 0 Where table_name = @tableName and status = 1; Update table_ Set is_busy = 0 Where name = @tableName; " +
                    "Commit;";


                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@tableName", tableName);

                    result = command.ExecuteNonQuery();

                    return result > 0;
                }
            }
            
        }

        public bool DeleteDiscount(string tableName)
        {
            int result = 0;

            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Begin Transaction; " +
                    "Update [sale] Set discount = @discount Where order_id = (Select id From [order] Where table_name = @tableName and status = 1); " +
                    "Commit;";


                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@tableName", tableName);
                    command.Parameters.AddWithValue("@discount", 0);

                    result = command.ExecuteNonQuery();

                    return result > 0;
                }
            }
        }

        public bool GetPaid(string tableName, decimal paid, string paymentMethod)
        {
            int result = 0;

            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Begin Transaction; " +
                    "Insert Into payment (paid, date, sale_id, code, payment_method_id) " +
                    "Values (@paid, GETDATE(), (Select id From sale Where order_id = (Select id From [order] Where table_name = @tableName and status = 1)), NEWID(), (Select id From payment_method Where method = @paymentMethod)); " +
                    "Update sale Set total_paid += @paid Where id = (Select id From sale Where order_id = (Select id From [order] Where table_name = @tableName and status = 1)); " +
                    "Commit;";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tableName", tableName);
                    command.Parameters.AddWithValue("@paid", paid);
                    command.Parameters.AddWithValue("@paymentMethod", paymentMethod);

                    result = command.ExecuteNonQuery();

                    return result > 0;
                }
            }
        }

        

        public bool OpenAccount(string tableName)
        {
            int result = 0;

            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Begin Transaction; " +
                    "Update table_ Set is_busy = 1 Where name = @tableName; " +
                    "Insert Into [order] (code, table_name, date, status) " +
                    "Values(NEWID(), @tableName, GETDATE(), 1); " +
                    "Insert Into sale (code, date, status, order_id, discount, total_paid, total_price) " +
                    "Values(NEWID(), GETDATE(), 1, (Select id From [order] Where table_name = @tableName and status = 1), 0, 0, 0); " +
                    "Commit;";


                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@tableName", tableName);

                    result = command.ExecuteNonQuery();

                    return result > 0;
                }
            }
        }

        public bool ProductCancellation(int orderDetailId)
        {
            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Begin Transaction; " +
                    "Update product Set stock += (Select amount From order_detail Where id = @id) Where name = (Select name From order_detail Where id = @id); " +
                    "Update sale Set total_price -= (Select total_price From order_detail Where id = @id) Where order_id = (Select order_id From order_detail Where id = @id); " +
                    "Delete From order_detail Where id = @id; " +
                    "Commit;";


                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@id", orderDetailId);

                    int result = command.ExecuteNonQuery();

                    if (result > 0) { return true; }
                    else { return false; }
                }


            }
        }

        public bool TransferDesk(string tableName, string newTableName)
        {
            int result = 0;

            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Begin Transaction; " +
                    "Update [order] Set table_name = @newTableName Where status = 1 and table_name = @tableName; " +
                    "Update table_ Set is_busy = 0 Where name = @tableName; " +
                    "Update table_ Set is_busy = 1 Where name = @newTableName; " +
                    "Commit;";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tableName", tableName);
                    command.Parameters.AddWithValue("@newTableName", newTableName);

                    result = command.ExecuteNonQuery();

                    return result > 0;
                }
            }
        }

        public bool TransferProduct(int orderDetailId, string tableName)
        {
            int result = 0;

            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Begin Transaction; " +
                    "Update sale Set total_price -= (Select total_price From order_detail Where id = @orderDetailId) Where order_id = (Select [order].id From [order] Inner Join order_detail on order_detail.order_id = [order].id Where order_detail.id = @orderDetailId)" +
                    "Update order_detail Set order_id = (Select id From [order] Where table_name = @tableName and status = 1) " +
                    "Where id = @orderDetailId; " +
                    "Update sale Set total_price = (Select Sum(order_detail.total_price) From [order] Inner Join order_detail on order_detail.order_id = [order].id Where order_detail.order_id = (Select id From [order] Where table_name = @tableName and status = 1)) Where order_id = (Select id From [order] Where table_name = @tableName and status = 1); " +
                    "Commit;";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tableName", tableName);
                    command.Parameters.AddWithValue("@orderDetailId", orderDetailId);

                    result = command.ExecuteNonQuery();

                    return result > 0;
                }
            }
        }
    }
}
