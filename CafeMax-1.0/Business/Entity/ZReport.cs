using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.Business.Entity
{
    internal class ZReport
    {
        public int SaleAmount { get; set; }
        public decimal SaleTotalPrice { get; set; }
        public decimal ExpenseTotalPrice { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<Expense> Expenses { get; set; }

        public decimal CashPaid { get; set; }
        public decimal CreditCardPaid { get; set; }

        public decimal TotalDiscount { get; set; }

        public ZReport()
        {
            OrderDetails = new List<OrderDetail>();
            Expenses = new List<Expense>();
        }
    }
}
