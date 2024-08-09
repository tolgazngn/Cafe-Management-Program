using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.Business.Entity
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }  
        public string Address { get; set; }
        public DateTime DateOfEntry { get; set; }
        public DateTime DateOfExit { get; set; }
        public bool IsActive { get; set; }
        public decimal Salary { get; set; }
        public string Job { get; set; }
        public string Username { get; set; }

        public Employee() {  }

        public string GetFullName() {  return $"{Name} {Surname}"; }


    }
}
