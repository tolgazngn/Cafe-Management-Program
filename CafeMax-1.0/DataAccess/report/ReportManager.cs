using CafeMax.Business.Entity;
using CafeMax.DataAccess.database;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.DataAccess.report
{
    internal class ReportManager : IReportManager
    {
        public IDatabase database;

        public ReportManager() { database = new MsSqlDatabase(); }

        public ZReport GetZRaport(DateTime firstDate, DateTime lastDate)
        {
            ZReport zReport = new ZReport();

            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select Sum(total_paid) as total_paid, Count(*) as total_rows, Sum(discount) as discount From [sale] Where [date] Between @firstDate And @lastDate;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@firstDate", firstDate);
                    command.Parameters.AddWithValue("@lastDate", lastDate);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["total_paid"] != DBNull.Value) { zReport.SaleTotalPrice = (decimal)reader["total_paid"]; }
                            if (reader["total_rows"] != DBNull.Value) { zReport.SaleAmount = (int)reader["total_rows"]; }
                            if (reader["discount"] != DBNull.Value) { zReport.TotalDiscount = (decimal)reader["discount"]; }
                        }
                        
                    }
                }

                string query2 = "Select Sum(paid) as cash_paid From payment Where payment_method_id = (Select id From payment_method Where method = 'Nakit') and [date] Between @firstDate And @lastDate; " +
                    "Select Sum(paid) as card_paid From payment Where payment_method_id = (Select id From payment_method Where method = 'Banka Kartı') and [date] Between @firstDate And @lastDate;";

                using (SqlCommand command = new SqlCommand(query2, connection))
                {
                    command.Parameters.AddWithValue("@firstDate", firstDate);
                    command.Parameters.AddWithValue("@lastDate", lastDate);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                
                                if (reader["cash_paid"] != DBNull.Value) { zReport.CashPaid = (decimal)reader["cash_paid"]; }
                            }
                        }


                        if (reader.NextResult())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    if (reader["card_paid"] != DBNull.Value) { zReport.CreditCardPaid = (decimal)reader["card_paid"]; }
                                        
                                }
                            }
                        }

                    }
                }

                string query3 = "Select [name], Sum(amount) as total_amount, Sum(total_price) as total_price From order_detail Where order_id in (Select id From [order] Where [date] Between @firstDate And @lastDate) Group By order_detail.name";

                using (SqlCommand command = new SqlCommand(query3, connection))
                {
                    command.Parameters.AddWithValue("@firstDate", firstDate);
                    command.Parameters.AddWithValue("@lastDate", lastDate);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OrderDetail orderDetail = new OrderDetail();

                            if (reader["name"] != DBNull.Value) { orderDetail.ProductName = (string)reader["name"]; }
                            if (reader["total_amount"] != DBNull.Value) { orderDetail.Amount = (int)reader["total_amount"]; }
                            if (reader["total_price"] != DBNull.Value) { orderDetail.TotalPrice = (decimal)reader["total_price"]; }
                                    
                            zReport.OrderDetails.Add(orderDetail);
                        }

                    }
                }

                string query4 = "Select type, amount, paid From expense Where [date] Between @firstDate And @lastDate";

                using (SqlCommand command = new SqlCommand(query4, connection))
                {
                    command.Parameters.AddWithValue("@firstDate", firstDate);
                    command.Parameters.AddWithValue("@lastDate", lastDate);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Expense expense = new Expense();

                            if (reader["type"] != DBNull.Value) { expense.Type = (string)reader["type"]; }
                            if (reader["amount"] != DBNull.Value) { expense.Amount = (int)reader["amount"]; }
                            if (reader["paid"] != DBNull.Value) { expense.Paid = (decimal)reader["paid"]; }
                            

                            zReport.Expenses.Add(expense);
                        }

                    }
                }

                string query5 = "Select Sum(paid) as total_paid From expense Where [date] Between @firstDate And @lastDate";

                using (SqlCommand command = new SqlCommand(query5, connection))
                {
                    command.Parameters.AddWithValue("@firstDate", firstDate);
                    command.Parameters.AddWithValue("@lastDate", lastDate);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["total_paid"] != DBNull.Value) { zReport.ExpenseTotalPrice = (decimal)reader["total_paid"]; }
                            
                        }

                    }
                }

                string query6 = "SWhere [date] Between @firstDate And @lastDate";

                using (SqlCommand command = new SqlCommand(query5, connection))
                {
                    command.Parameters.AddWithValue("@firstDate", firstDate);
                    command.Parameters.AddWithValue("@lastDate", lastDate);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["total_paid"] != DBNull.Value) { zReport.ExpenseTotalPrice = (decimal)reader["total_paid"]; }

                        }

                    }
                }

                connection.Close();
            }

            return zReport;
        }
    }
}
