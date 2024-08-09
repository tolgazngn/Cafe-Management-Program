using CafeMax.Business.Entity;
using CafeMax.Business.Service.abstracts;
using CafeMax.DataAccess.paymentmethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.Business.Service.concretes
{
    internal class PaymentMethodService : IPaymentMethodService
    {
        public PaymentMethodService() {  }

        public List<PaymentMethod> GetAll()
        {
            PaymentMethodManager paymentMethodManager = new PaymentMethodManager();

            return paymentMethodManager.GetAll();
        }
    }
}
