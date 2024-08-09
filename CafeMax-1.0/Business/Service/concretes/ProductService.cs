using CafeMax.Business.Entity;
using CafeMax.Business.Service.abstracts;
using CafeMax.DataAccess.product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeMax.Business.Service.concretes
{
    internal class ProductService : IProductService
    {
        public ProductService() {  }

        public bool AddProduct(Product product)
        {
            ProductManager productManager = new ProductManager();

            return productManager.AddProduct(product);
        }

        public bool AddStock(string productName, short value)
        {
            ProductManager productManager = new ProductManager();

            return productManager.AddStock(productName, value);
        }

        public bool ChangeUnitPrice(string productName, decimal unitPrice)
        {
            ProductManager productManager = new ProductManager();

            return productManager.ChangeUnitPrice(productName, unitPrice);
        }

        public bool CheckProductNameAvailability(string productName)
        {
            ProductManager productManager = new ProductManager();

            return productManager.CheckProductNameAvailability(productName);
        }

        public bool DeleteProduct(string productName)
        {
            ProductManager productManager = new ProductManager();

            return productManager.DeleteProduct(productName);
        }

        public List<Product> GetProductsByMenu(string menuName)
        {
            ProductManager productManager = new ProductManager();

            return productManager.GetProductsByMenu(menuName);
        }

        public Product GetUnitPriceByName(string productName)
        {
            ProductManager productManager = new ProductManager();

            return productManager.GetUnitPriceByName(productName);
        }
    }
}
