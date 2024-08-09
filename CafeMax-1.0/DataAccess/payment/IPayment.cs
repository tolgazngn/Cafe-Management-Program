using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeMax.Business.Entity;

namespace CafeMax.DataAccess.payment
{
    interface IPayment
    {
        bool AddPayment(Guid saleCode, decimal paid, string paymentMethod);
        List<Payment> GetPaymentsBySaleCode(Guid saleCode);
        bool DeletePayment(Guid paymentCode);

        List<Payment> GetPaymentsBySaleId(Guid saleCode);

        List<Payment> GetPaymentsByTableName(string tableName);
    }
}
