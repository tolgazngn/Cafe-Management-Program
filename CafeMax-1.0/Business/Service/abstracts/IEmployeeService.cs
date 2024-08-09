using CafeMax.Business.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.Business.Service.abstracts
{
    internal interface IEmployeeService
    {
        bool AddEmployee(Employee employee);
        bool DeleteEmployee(int id);
        bool ChangePhoneNumber(int id, string phoneNumber);
        bool ChangeEmail(int id, string email);
        bool ChangeActivityById(int id, bool activity);
        bool ChangeJobById(int id, string job);
        List<Employee> GetAll();
        List<Employee> GetEmployeesByName(string name);
        Employee GetEmployeeByUsername(string username);
        string GetJobById(int id);
        bool CheckEmailAvailability(string email);
        bool CheckPhoneNumberAvailability(string phoneNumber);
        string GetFullNameById(int id);
    }
}
