using CafeMax.Business.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.Business.Service.abstracts
{
    internal interface IOrderService
    {
        List<Order> GetLastFiftyOrder();

        void AddOrder(string tableName);


        Order GetOrderByTableName(string tableName);

        List<Order> GetOpenOrders();

        List<Order> GetOrdersByDate(DateTime firstDate, DateTime secondDate);

        List<Order> GetAll();
    }
}
