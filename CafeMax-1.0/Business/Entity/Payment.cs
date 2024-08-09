using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.Business.Entity
{
    class Payment
    {
        public int Id { get; set; }
        public Guid Code { get; set; }
        public decimal Paid { get; set; }
        public DateTime Date { get; set; }
        public int SaleId { get; set; }
        public int PaymentMethodId{ get; set; }

        public string PaymentMethod { get; set; }

    }
}
