using CafeMax.Business.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.DataAccess.product
{
    interface IProduct
    {
        bool AddProduct(Product product);
        bool DeleteProduct(string productName);
        bool AddStock(string productName, short stock);
        bool ChangeUnitPrice(string productName, decimal unitPrice);
        bool ChangeStock(string productName, short stock);
        List<Product> GetAll();

        List<Product> GetProductsByMenu(string menuName);

        Product GetUnitPriceByName(string productName);

        bool CheckProductNameAvailability(string productName);
    }
}
