using CafeMax.Business.Entity;
using CafeMax.Business.Service.abstracts;
using CafeMax.DataAccess.employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CafeMax.Business.Service.concretes
{
    internal class EmployeeService : IEmployeeService
    {
        public EmployeeService() {}

        public bool AddEmployee(Employee employee)
        {
            EmployeeManager employeeManager = new EmployeeManager();

            return employeeManager.AddEmployee(employee);
        }

        public bool ChangeActivityById(int id, bool value)
        {
            EmployeeManager employeeManager = new EmployeeManager();

            return employeeManager.ChangeActivityById(id, value);
        }


        public bool ChangeEmail(int id, string email)
        {
            EmployeeManager employeeManager = new EmployeeManager();

            return employeeManager.ChangeEmail(id, email);
        }

        public bool ChangeJobById(int id, string job)
        {
            EmployeeManager employeeManager = new EmployeeManager();

            return employeeManager.ChangeJobById(id, job);
        }

        public bool ChangePhoneNumber(int id, string phoneNumber)
        {
            EmployeeManager employeeManager = new EmployeeManager();

            return employeeManager.ChangePhoneNumber(id, phoneNumber);
        }

        public bool CheckEmailAvailability(string email)
        {
            EmployeeManager employeeManager = new EmployeeManager();

            return employeeManager.CheckEmailAvailability(email);
        }

        public bool CheckPhoneNumberAvailability(string phoneNumber)
        {
            EmployeeManager employeeManager = new EmployeeManager();

            return employeeManager.CheckPhoneNumberAvailability(phoneNumber);
        }

        public bool DeleteEmployee(int id)
        {
            EmployeeManager employeeManager = new EmployeeManager();

            return employeeManager.DeleteEmployee(id);
        }

        public List<Employee> GetAll()
        {
            EmployeeManager employeeManager = new EmployeeManager();

            return employeeManager.GetAll();
        }

        public Employee GetEmployeeByUsername(string username)
        {
            EmployeeManager employeeManager = new EmployeeManager();

            return employeeManager.GetEmployeeByUsername(username);
        }

        public List<Employee> GetEmployeesByName(string name)
        {
            EmployeeManager employeeManager = new EmployeeManager();

            return employeeManager.GetEmployeesByName(name);
        }

        public string GetFullNameById(int id)
        {
            EmployeeManager employeeManager = new EmployeeManager();

            return employeeManager.GetFullNameById(id);
        }

        public string GetJobById(int id)
        {
            EmployeeManager employeeManager = new EmployeeManager();

            return employeeManager.GetJobById(id);
        }
    }
}
