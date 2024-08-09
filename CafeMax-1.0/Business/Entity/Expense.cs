using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.Business.Entity
{
    class Expense
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
        public decimal Paid { get; set; }
        public DateTime Date { get; set; }
        public string PaymentMethod { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeFullName { get; set; }
    }
}
