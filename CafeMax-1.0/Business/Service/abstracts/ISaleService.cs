using CafeMax.Business.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.Business.Service.abstracts
{
    internal interface ISaleService
    {
        bool AddSale(string tableName);

        bool AddDiscount(Guid saleCode, decimal discount);
        bool AddTotalPaid(Guid saleCode, decimal paid);

        bool AddTotalPrice(string table_name, decimal price);

        Sale GetSaleByOrderId(Guid orderCode);

        List<Sale> GetOpenSales();

        List<Sale> GetAll();

        List<Sale> GetSalesByDate(DateTime firstDate, DateTime secondDate);

        Sale GetSaleByTableName(string tableName);

    }
}
