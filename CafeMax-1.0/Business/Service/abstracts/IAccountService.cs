using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.Business.Service.abstracts
{
    internal interface IAccountService
    {
        bool Open(string tableName);
        bool Close(string tableName);
        bool TransferDesk(string tableName, string newTableName);
        bool TransferProduct(int orderDetailId, string tableName);
        bool GetPaid(string tableName, decimal paid, string paymentMethod);

        bool ProductCancellation(int orderDetailId);

        bool AddDiscount(string tableName, decimal discount);

        bool DeleteDiscount(string tableName);
    }
}
