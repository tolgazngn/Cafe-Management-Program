using CafeMax.Business.Entity;
using CafeMax.DataAccess.database;
using CafeMax.DataAccess.table;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.DataAccess.paymentmethod
{
    class PaymentMethodManager : IPaymentMethod
    {
        public IDatabase database;

        public PaymentMethodManager() { database = new MsSqlDatabase(); }

        public bool AddPaymentMethod(string method)
        {
            throw new NotImplementedException();
        }

        public bool DeletePaymentMethod(string method)
        {
            throw new NotImplementedException();
        }

        public List<PaymentMethod> GetAll()
        {
            List<PaymentMethod> paymentMethods = new List<PaymentMethod> ();


            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select * From payment_method";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        PaymentMethod paymentMethod = new PaymentMethod();

                        paymentMethod.Title = (string)reader["method"];

                        paymentMethods.Add(paymentMethod);
                    }
                }

            }

            return paymentMethods;
        }
    }
}
