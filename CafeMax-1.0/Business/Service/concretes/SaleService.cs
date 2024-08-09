using CafeMax.Business.Entity;
using CafeMax.Business.Service.abstracts;
using CafeMax.Business.Util;
using CafeMax.DataAccess.sale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.Business.Service.concretes
{
    internal class SaleService : ISaleService
    {
        public SaleService() {  }

        public bool AddDiscount(Guid saleCode, decimal discount)
        {
            SaleManager saleManager = new SaleManager();

            return saleManager.AddDiscount(saleCode, discount);
        }

        public bool AddSale(string tableName)
        {
            SaleManager saleManager = new SaleManager();

            return saleManager.AddSale(tableName);
        }

        public bool AddTotalPaid(Guid saleCode, decimal paid)
        {
            SaleManager saleManager = new SaleManager();

            return saleManager.AddTotalPaid(saleCode, paid);
        }

        public bool AddTotalPrice(string table_name, decimal price)
        {
            SaleManager saleManager = new SaleManager();

            return saleManager.AddTotalPrice(table_name, price);
        }

       

        public List<Sale> GetAll()
        {
            SaleManager saleManager = new SaleManager();

            return saleManager.GetAll();
        }

        public List<Sale> GetOpenSales()
        {
            SaleManager saleManager = new SaleManager();

            return saleManager.GetOpenSales();
        }

        public Sale GetSaleByOrderId(Guid orderCode)
        {
            SaleManager saleManager = new SaleManager();

            return saleManager.GetSaleByOrderId(orderCode);
        }

        

        public Sale GetSaleByTableName(string tableName)
        {
            SaleManager saleManager = new SaleManager();

            return saleManager.GetSaleByTableName(tableName);
        }

        public List<Sale> GetSalesByDate(DateTime firstDate, DateTime secondDate)
        {
            SaleManager saleManager = new SaleManager();

            return saleManager.GetSalesByDate(Helper.EditDateForSearch(firstDate, 0,0,0), Helper.EditDateForSearch(secondDate, 23, 59, 59));
        }
    }
}
