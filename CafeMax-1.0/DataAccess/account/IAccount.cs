using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.DataAccess.account
{
    internal interface IAccount
    {
        bool OpenAccount(string tableName);
        bool CloseAccount(string tableName);

        bool TransferDesk(string tableName, string newTableName);

        bool TransferProduct(int orderDetailId, string tableName);

        bool GetPaid(string tableName, decimal paid, string paymentMethod);

        bool ProductCancellation(int orderDetailId);

        bool AddDiscount(string tableName, decimal discount);

        bool DeleteDiscount(string tableName);
    }
}
