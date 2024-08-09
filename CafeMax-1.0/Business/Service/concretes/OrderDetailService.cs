using CafeMax.Business.Entity;
using CafeMax.Business.Service.abstracts;
using CafeMax.DataAccess.orderdetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.Business.Service.concretes
{
    internal class OrderDetailService : IOrderDetailService
    {
        
        public OrderDetailService() { }

        public bool AddOrderDetail(OrderDetail orderDetail, string tableName)
        {
            OrderDetailManager orderDetailManager = new OrderDetailManager();

            return orderDetailManager.AddOrderDetail(orderDetail, tableName);
        }

        public List<OrderDetail> GetOrderDetailsByOrderId(Guid orderCode)
        {
            OrderDetailManager orderDetailManager = new OrderDetailManager();

            return orderDetailManager.GetOrderDetailsByOrderId(orderCode);
        }

        public List<OrderDetail> GetOrderDetailsByTableName(string tableName)
        {
            OrderDetailManager orderDetailManager = new OrderDetailManager();

            return orderDetailManager.GetOrderDetailsByTableName(tableName);
        }

        
    }
}
