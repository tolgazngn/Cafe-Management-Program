using CafeMax.Business.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.DataAccess.paymentmethod
{
    interface IPaymentMethod
    {
        bool AddPaymentMethod(string method);
        List<PaymentMethod> GetAll();
        bool DeletePaymentMethod(string method);
    }
}
