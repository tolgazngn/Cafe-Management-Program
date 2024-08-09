using CafeMax.Business.Entity;
using CafeMax.DataAccess.database;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CafeMax.DataAccess.expense
{
    class ExpenseManager : IExpense
    {
        public IDatabase database;

        public ExpenseManager() { database = new MsSqlDatabase(); }

        public bool AddExpense(Expense expense)
        {
            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Insert Into expense Values(@type, @amount, @description, @paid, (Select id From payment_method Where method = @paymentMethod), @employeeId, GETDATE())";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@type", expense.Type);
                    command.Parameters.AddWithValue("@amount", expense.Amount);
                    command.Parameters.AddWithValue("@description", expense.Description);
                    command.Parameters.AddWithValue("@paid", expense.Paid);
                    command.Parameters.AddWithValue("@paymentMethod", expense.PaymentMethod);
                    command.Parameters.AddWithValue("@EmployeeId", expense.EmployeeId);

                    int result = command.ExecuteNonQuery();

                    return result > 0;
                }
            }
        }

        public List<Expense> GetAll()
        {
            List<Expense> expenses = new List<Expense>();

            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select expense.id, expense.type, expense.amount, expense.description, expense.paid, expense.date, payment_method.method, CONCAT(employee.name, ' ', employee.surname) as fullname " +
                    "From expense " +
                    "Inner Join employee on employee.id = expense.employee_id " +
                    "Inner Join payment_method on payment_method.id = expense.payment_method_id ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Expense expense = new Expense();

                            expense.Id = (int)reader["id"];
                            expense.Type = (string)reader["type"];
                            expense.Amount = (int)reader["amount"];
                            expense.Description = (string)reader["description"];
                            expense.Paid = (decimal)reader["paid"];
                            expense.PaymentMethod = (string)reader["method"];
                            expense.EmployeeFullName = (string)reader["fullname"];
                            expense.Date = (DateTime)reader["date"];

                            expenses.Add(expense);
                        }
                        connection.Close();
                    }
                }
            }

            return expenses;
        }

        public List<Expense> GetExpensesByDate(DateTime firstDate, DateTime secondDate)
        {
            List<Expense> expenses = new List<Expense>();

            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select expense.id, expense.type, expense.amount, expense.description, expense.paid, expense.date, payment_method.method, CONCAT(employee.name, ' ', employee.surname) as fullname " +
                    "From expense " +
                    "Inner Join employee on employee.id = expense.employee_id " +
                    "Inner Join payment_method on payment_method.id = expense.payment_method_id " +
                    "Where expense.[date] between @firstDate and @secondDate";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@firstDate", firstDate);
                    command.Parameters.AddWithValue("@secondDate", secondDate);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Expense expense = new Expense();

                            expense.Id = (int)reader["id"];
                            expense.Type = (string)reader["type"];
                            expense.Amount = (int)reader["amount"];
                            expense.Description = (string)reader["description"];
                            expense.Paid = (decimal)reader["paid"];
                            expense.PaymentMethod = (string)reader["method"];
                            expense.EmployeeFullName = (string)reader["fullname"];
                            expense.Date = (DateTime)reader["date"];

                            expenses.Add(expense);
                        }
                        connection.Close();
                    }
                }
            }

            return expenses;
        }
    }
}
