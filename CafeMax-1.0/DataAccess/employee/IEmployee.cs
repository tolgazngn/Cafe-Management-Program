using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeMax.Business.Entity;

namespace CafeMax.DataAccess.employee
{
    interface IEmployee
    {
        bool AddEmployee(Employee employee);
        bool DeleteEmployee(int id);
        bool ChangePhoneNumber(int id, string phoneNumber);
        bool ChangeEmail(int id, string email);
        bool ChangeActivityById(int id, bool value);
        bool ChangeJobById(int id, string job);
        List<Employee> GetAll();
        List<Employee> GetEmployeesByName(string name);
        Employee GetEmployeeByUsername(string username);
        string GetJobById(int id);

        string GetFullNameById(int id);

        bool CheckEmailAvailability(string email);

        bool CheckPhoneNumberAvailability(string phoneNumber);
    }
}
