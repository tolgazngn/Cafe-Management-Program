using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeMax.Business.Entity;
using CafeMax.DataAccess.database;
using Microsoft.Data.SqlClient;

namespace CafeMax.DataAccess.payment
{
    class PaymentManager : IPayment
    {
        public IDatabase database;

        public PaymentManager() { database = new MsSqlDatabase(); }

        public bool AddPayment(Guid saleCode, decimal paid, string paymentMethod)
        {
            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Insert Into payment (paid, date, sale_id, code, payment_method_id) " +
                    "Values (@paid, GETDATE(), (Select id From [sale] Where code = @saleCode), NEWID(), (Select id From payment_method Where method = @paymentMethod))";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@paid", paid);
                    command.Parameters.AddWithValue("@saleCode", saleCode);
                    command.Parameters.AddWithValue("@paymentMethod", paymentMethod);

                    int result = command.ExecuteNonQuery();

                    if (result > 0) { return true; }
                    else { return false; }
                }
            }
        }

        public bool DeletePayment(Guid paymentCode)
        {
            throw new NotImplementedException();
        }

        public List<Payment> GetPaymentsBySaleCode(Guid saleCode)
        {
            throw new NotImplementedException();
        }

        public List<Payment> GetPaymentsBySaleId(Guid saleCode)
        {
            List<Payment> payments = new List<Payment>();


            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select * From payment Where sale_id = (Select id From [sale] Where code = @saleCode)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@saleCode", saleCode);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Payment payment = new Payment();

                        payment.Id = (int)reader["id"];
                        payment.Paid = (decimal)reader["paid"];
                        payment.Code = (Guid)reader["code"];
                        payment.Date = (DateTime)reader["date"];
                        payment.SaleId = (int)reader["sale_id"];
                        payment.PaymentMethodId = (int)reader["payment_method_id"];

                        payments.Add(payment);
                    }
                }

            }

            return payments;
        }

        public List<Payment> GetPaymentsByTableName(string tableName)
        {
            List<Payment> payments = new List<Payment>();


            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select payment.id, payment.paid, payment.date, payment.code, payment_method.method, sale.id as sale_id " +
                    "From payment " +
                    "Inner Join payment_method on payment_method.id = payment.payment_method_id " +
                    "Inner Join sale on sale.id = payment.sale_id " +
                    "Where sale.order_id = (Select id From [order] Where table_name = @tableName and status = 1)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tableName", tableName);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Payment payment = new Payment();

                        payment.Id = (int)reader["id"];
                        payment.Paid = (decimal)reader["paid"];
                        payment.Code = (Guid)reader["code"];
                        payment.Date = (DateTime)reader["date"];
                        payment.SaleId = (int)reader["sale_id"];
                        payment.PaymentMethod = (string)reader["method"];

                        payments.Add(payment);
                    }
                }

            }

            return payments;
        }
    }
}
