using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeMax.Business.Entity;

namespace CafeMax.DataAccess.order
{
    interface IOrder
    {
        void AddOrder(string tableName);

        bool CloseOrder(Guid code);

        List<Order> GetLastFiftyOrder();

        List<Order> GetAll();

        List<Order> GetOrdersByDate(DateTime firstDate, DateTime secondDate);

        Order GetOrderByTableName(string tableName);

        List<Order> GetOpenOrders();



    }
}
