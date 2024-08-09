using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeMax.Business.Entity;

namespace CafeMax.DataAccess.orderdetail
{
    interface IOrderDetail
    {
        List<OrderDetail> GetOrderDetailsByCode(string ordercode);
        bool AddOrderDetail(OrderDetail orderDetail, string tableName);

        decimal GetTotalPrice(string tableName);

        List<OrderDetail> GetOrderDetailsByOrderId(Guid orderCode);

        List<OrderDetail> GetOrderDetailsByTableName(string tableName);
        
    }
}
