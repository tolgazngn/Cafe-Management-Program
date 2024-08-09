using CafeMax.Business.Entity;
using CafeMax.Business.Service.abstracts;
using CafeMax.Business.Util;
using CafeMax.DataAccess.order;
using CafeMax.DataAccess.orderdetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.Business.Service.concretes
{
    internal class OrderService : IOrderService
    {

        public OrderService() {  }

        public void AddOrder(string tableName)
        {
            OrderManager orderManager = new OrderManager();

            orderManager.AddOrder(tableName);
        }

        

        public List<Order> GetAll()
        {
            OrderManager orderManager = new OrderManager();

            return orderManager.GetAll();
        }

        public List<Order> GetLastFiftyOrder()
        {
            OrderManager orderManager = new OrderManager();

            return orderManager.GetLastFiftyOrder();
        }

        public List<Order> GetOpenOrders()
        {
            OrderManager orderManager = new OrderManager();

            return orderManager.GetOpenOrders();
        }

        public Order GetOrderByTableName(string tableName)
        {
            OrderManager orderManager = new OrderManager();

            return orderManager.GetOrderByTableName(tableName);
        }

        public List<Order> GetOrdersByDate(DateTime firstDate, DateTime secondDate)
        {
            OrderManager orderManager = new OrderManager();

            return orderManager.GetOrdersByDate(Helper.EditDateForSearch(firstDate, 0, 0, 0), Helper.EditDateForSearch(secondDate, 23, 59, 59));
        }
    }
}
