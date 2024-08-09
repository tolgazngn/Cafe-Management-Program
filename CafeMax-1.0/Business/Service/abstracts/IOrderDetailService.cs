using CafeMax.Business.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.Business.Service.abstracts
{
    internal interface IOrderDetailService
    {
        bool AddOrderDetail(OrderDetail orderDetail, string tableName);

        List<OrderDetail> GetOrderDetailsByOrderId(Guid orderCode);

        List<OrderDetail> GetOrderDetailsByTableName(string tableName);

        
    }
}
