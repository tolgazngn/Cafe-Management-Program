using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeMax.Business.Entity;

namespace CafeMax.DataAccess.sale
{
    interface ISale
    {
        bool AddSale(string tableName);
        bool AddDiscount(Guid saleCode, decimal discount);

        bool AddTotalPaid(Guid saleCode, decimal paid);

        bool AddTotalPrice(string table_name, decimal price);

        List<Sale> GetAll();
        List<Sale> GetSalesByDate(DateTime firstDate, DateTime secondDate);

        Sale GetSaleByOrderId(Guid orderCode);

        Sale GetSaleByTableName(string tableName);

        List<Sale> GetOpenSales();

    }
}
