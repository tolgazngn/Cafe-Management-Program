using CafeMax.Business.Entity;
using CafeMax.Business.Service.abstracts;
using CafeMax.DataAccess.payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.Business.Service.concretes
{
    internal class PaymentService : IPaymentService
    {
        public PaymentService() {  }

        public bool AddPayment(Guid saleCode, decimal paid, string paymentMethod)
        {
            PaymentManager paymentManager = new PaymentManager();

            return paymentManager.AddPayment(saleCode, paid, paymentMethod);
        }

        public bool DeletePayment(string paymentCode)
        {
            throw new NotImplementedException();
        }

        public List<Payment> GetPaymentsBySaleCode(string saleCode)
        {
            throw new NotImplementedException();
        }

        public List<Payment> GetPaymentsBySaleId(Guid saleCode)
        {
            PaymentManager paymentManager = new PaymentManager();

            return paymentManager.GetPaymentsBySaleId(saleCode);
        }

        public List<Payment> GetPaymentsByTableName(string tableName)
        {
            PaymentManager paymentManager = new PaymentManager();

            return paymentManager.GetPaymentsByTableName(tableName);
        }
    }
}
