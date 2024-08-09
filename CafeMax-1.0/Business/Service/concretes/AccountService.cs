using CafeMax.Business.Service.abstracts;
using CafeMax.DataAccess.account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.Business.Service.concretes
{
    internal class AccountService : IAccountService
    {
        public AccountService() { }

        public bool AddDiscount(string tableName, decimal discount)
        {
            AccountManager accountManager = new AccountManager();
            return accountManager.AddDiscount(tableName, discount);
        }

        public bool Close(string tableName)
        {
            AccountManager accountManager = new AccountManager();
            return accountManager.CloseAccount(tableName);
        }

        public bool DeleteDiscount(string tableName)
        {
            AccountManager accountManager = new AccountManager();
            return accountManager.DeleteDiscount(tableName);
        }

        public bool GetPaid(string tableName, decimal paid, string paymentMethod)
        {
            AccountManager accountManager = new AccountManager();
            return accountManager.GetPaid(tableName, paid, paymentMethod);
        }

        public bool Open(string tableName)
        {
            AccountManager accountManager = new AccountManager();
            return accountManager.OpenAccount(tableName);
        }

        public bool ProductCancellation(int orderDetailId)
        {
            AccountManager accountManager = new AccountManager();
            return accountManager.ProductCancellation(orderDetailId);
        }

        public bool TransferDesk(string tableName, string newTableName)
        {
            AccountManager accountManager = new AccountManager();
            return accountManager.TransferDesk(tableName, newTableName);
        }

        public bool TransferProduct(int orderDetailId, string tableName)
        {
            AccountManager accountManager = new AccountManager();
            return accountManager.TransferProduct(orderDetailId, tableName);
        }
    }
}
