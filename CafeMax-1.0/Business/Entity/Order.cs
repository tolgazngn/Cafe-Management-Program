using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.Business.Entity
{
    class Order
    {
        public int Id { get; set; }
        public Guid Code { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public string TableName { get; set; }
        public Sale Sale { get; set; }

        public OrderDetail OrderDetail { get; set; }


        //add method for OrderDetails 
    }
}
