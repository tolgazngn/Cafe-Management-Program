using CafeMax.Business.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.Business.Service.abstracts
{
    internal interface IProductService
    {
        List<Product> GetProductsByMenu(string menuName);

        Product GetUnitPriceByName(string productName);

        bool AddStock(string productName, short value);

        bool DeleteProduct(string productName);
        bool AddProduct(Product product);

        bool ChangeUnitPrice(string productName, decimal unitPrice);

        bool CheckProductNameAvailability(string productName);
    }
}
