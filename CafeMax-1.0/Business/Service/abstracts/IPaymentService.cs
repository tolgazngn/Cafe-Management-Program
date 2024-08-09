using CafeMax.Business.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.Business.Service.abstracts
{
    internal interface IPaymentService
    {
        List<Payment> GetPaymentsBySaleId(Guid saleCode);

        bool AddPayment(Guid saleCode, decimal paid, string paymentMethod);

        List<Payment> GetPaymentsByTableName(string tableName);
    }
}
