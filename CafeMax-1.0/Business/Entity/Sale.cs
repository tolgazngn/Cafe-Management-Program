using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.Business.Entity
{
    class Sale
    {
        public int Id { get; set; }
        public Guid Code { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPaid { get; set; }
        public bool Status { get; set; }

        public string TableName { get; set; }
        public Order Order { get; set; }
        public List<Payment> Payments;
    }
}
