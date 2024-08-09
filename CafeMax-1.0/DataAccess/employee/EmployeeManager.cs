using CafeMax.Business.Entity;
using CafeMax.DataAccess.database;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CafeMax.DataAccess.employee
{
    class EmployeeManager : IEmployee
    {
        public IDatabase database;

        public EmployeeManager() { database = new MsSqlDatabase(); }

        public bool AddEmployee(Employee employee)
        {
            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Insert Into employee (name, surname, phone_number, email, address, date_of_entry, is_active, salary, job_id) " +
                    "Values(@name, @surname, @phone_number, @email, @address, GETDATE(), 1, @salary, (Select id From job Where job = @job))";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", employee.Name);
                    command.Parameters.AddWithValue("@surname", employee.Surname);

                    //belirtilen değer null olarak gelmişse null ataması için bu kontrol kullanılır
                    if (employee.PhoneNumber != null) { command.Parameters.AddWithValue("@phone_number", employee.PhoneNumber); }
                    else { command.Parameters.AddWithValue("@phone_number", DBNull.Value); }

                    if (employee.Email != null) { command.Parameters.AddWithValue("@email", employee.Email); }
                    else { command.Parameters.AddWithValue("@email", DBNull.Value); }

                    if (employee.Address != null) { command.Parameters.AddWithValue("@address", employee.Address); }
                    else { command.Parameters.AddWithValue("@address", DBNull.Value); }

                    command.Parameters.AddWithValue("@salary", employee.Salary);
                    command.Parameters.AddWithValue("@job", employee.Job);

                    int result = command.ExecuteNonQuery();

                    return result > 0;
                }
            }
        }

        public bool ChangeActivityById(int id, bool value)
        {
            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Update employee Set is_active = @value Where id = @id and id != 10";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@value", value);
                    
                    int result = command.ExecuteNonQuery();

                    return result > 0;
                }
            }
        }

        public bool ChangeEmail(int id, string email)
        {
            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Update employee Set email = @email Where id = @id and id != 10";

                using (SqlCommand command = new SqlCommand(query, connection)) 
                {
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@id", id);

                    int result = command.ExecuteNonQuery();

                    return result > 0;
                }
            }
        }

        public bool ChangeJobById(int id, string job)
        {
            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Update employee Set job_id = (Select id From job Where job = @job) Where id = @id and id != 10";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@job", job);

                    int result = command.ExecuteNonQuery();

                    return result > 0;
                }
            }
        }

        public bool ChangePhoneNumber(int id, string phoneNumber)
        {
            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Update employee Set phone_number = @phoneNumber Where id = @id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@id", id);

                    int result = command.ExecuteNonQuery();

                    return result > 0;
                }
            }
        }

        public bool CheckEmailAvailability(string email)
        {
            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select email From employee Where email = @email and";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);

                    int result = command.ExecuteNonQuery();

                    return result > 0;
                }
            }
        }

        public bool CheckPhoneNumberAvailability(string phoneNumber)
        {
            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select phone_number From employee Where phone_number = @phoneNumber";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@phoneNumber", phoneNumber);

                    int result = command.ExecuteNonQuery();

                    return result > 0;
                }
            }
        }

        public bool DeleteEmployee(int id)
        {
            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Delete From employee Where id = @id and id != 10";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    int result = command.ExecuteNonQuery();

                    return result > 0;
                }
            }
        }

        public List<Employee> GetAll()
        {
            List<Employee> employees = new List<Employee>();

            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select employee.id, employee.name, employee.surname, employee.phone_number, employee.email, employee.address, employee.date_of_entry, employee.date_of_exit, employee.is_active, employee.salary, job.job " +
                    "From employee " +
                    "Inner Join job on job.id = employee.job_id Where employee.id != 10";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee employee = new Employee();

                            employee.Id = (int)reader["id"];
                            employee.Name = (string)reader["name"];
                            employee.Surname = (string)reader["surname"];

                            if (reader["phone_number"] != DBNull.Value) { employee.PhoneNumber = (string)reader["phone_number"]; }

                            if (reader["email"] != DBNull.Value) { employee.Email = (string)reader["email"]; }

                            if (reader["address"] != DBNull.Value) { employee.Address = (string)reader["address"]; }

                            employee.DateOfEntry = (DateTime)reader["date_of_entry"];

                            if (reader["date_of_exit"] != DBNull.Value) { employee.DateOfExit = (DateTime)reader["date_of_exit"]; }

                            employee.IsActive = (bool)reader["is_active"];

                            if (reader["salary"] != DBNull.Value) { employee.Salary = (decimal)reader["salary"]; }

                            employee.Job = (string)reader["job"];

                            employees.Add(employee);
                        }
                        connection.Close();
                    }
                }
            }

            return employees;
        }

        public Employee GetEmployeeByUsername(string username)
        {
            Employee employee = new Employee();

            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select employee.id, employee.name, employee.surname, employee.phone_number, employee.email, employee.address, employee.date_of_entry, employee.date_of_exit, employee.is_active, employee.salary, job.job, [user].username " +
                    "From employee " +
                    "Inner Join [user] on [user].id = employee.id " +
                    "Inner Join [job] on job.id = employee.job_id " +
                    "Where [user].username = @username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            employee.Id = (int)reader["id"];
                            employee.Name = (string)reader["name"];
                            if (reader["surname"] != DBNull.Value) { employee.Surname = (string)reader["surname"]; } 

                            if (reader["phone_number"] != DBNull.Value) { employee.PhoneNumber = (string)reader["phone_number"]; }

                            if (reader["email"] != DBNull.Value) { employee.Email = (string)reader["email"]; }

                            if (reader["address"] != DBNull.Value) { employee.Address = (string)reader["address"]; }
                                
                            
                            if (reader["date_of_entry"] != DBNull.Value) { employee.DateOfEntry = (DateTime)reader["date_of_entry"]; }

                            if (reader["date_of_exit"] != DBNull.Value) { employee.DateOfExit = (DateTime)reader["date_of_exit"]; }
                                
                            if (reader["is_active"] != DBNull.Value) { employee.IsActive = (bool)reader["is_active"]; }

                            if (reader["salary"] != DBNull.Value) { employee.Salary = (decimal)reader["salary"]; }
                            
                            employee.Job = (string)reader["job"];
                            employee.Username = (string)reader["username"];
                        }
                        connection.Close();
                    }
                }
            }
            
            return employee;
        }

        public List<Employee> GetEmployeesByName(string name)
        {
            List<Employee> employees = new List<Employee>();

            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select employee.id, employee.name, employee.surname, employee.phone_number, employee.email, employee.address, employee.date_of_entry, employee.date_of_exit, employee.is_active, employee.salary, job.job " +
                    "From employee " +
                    "Inner Join job on job.id = employee.job_id " +
                    "Where name = @name and employee.id != 10";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@name", name);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee employee = new Employee();

                            employee.Id = (int)reader["id"];
                            employee.Name = (string)reader["name"];
                            employee.Surname = (string)reader["surname"];

                            if (reader["phone_number"] != DBNull.Value) { employee.PhoneNumber = (string)reader["phone_number"]; }

                            if (reader["email"] != DBNull.Value) { employee.Email = (string)reader["email"]; }

                            if (reader["address"] != DBNull.Value) { employee.Address = (string)reader["address"]; }

                            employee.DateOfEntry = (DateTime)reader["date_of_entry"];

                            if (reader["date_of_exit"] != DBNull.Value) { employee.DateOfExit = (DateTime)reader["date_of_exit"]; }

                            employee.IsActive = (bool)reader["is_active"];

                            if (reader["salary"] != DBNull.Value) { employee.Salary = (decimal)reader["salary"]; }

                            employee.Job = (string)reader["job"];

                            

                            employees.Add(employee);
                        }
                        connection.Close();
                    }
                }
            }

            return employees;
        }

        public string GetFullNameById(int id)
        {
            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select Concat(name, ' ', surname) As fullname From employee Where id = @id and id != 10";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return (string)reader["fullname"];
                        }
                        connection.Close();
                    }
                }
            }
            return null;
        }

        public string GetJobById(int id)
        {
            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select job.job " +
                    "From employee Inner Join job on job.id = employee.job_id " +
                    "Where employee.id = @id and employee.id != 10";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return (string)reader["job"];
                        }
                        connection.Close();
                    }
                }
            }
            return null;
        }
    }
}
