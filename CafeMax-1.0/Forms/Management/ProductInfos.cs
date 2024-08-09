using CafeMax.Business.Entity;
using CafeMax.Business.Service.abstracts;
using CafeMax.Business.Service.concretes;
using CafeMax.Business.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeMax.Forms.Management
{
    public partial class ProductInfos : Form
    {
        public ProductInfos()
        {
            InitializeComponent();
        }

        private void ProductInfos_Load(object sender, EventArgs e)
        {
            MenuService menuService = new MenuService();

            List<Menu> menus = menuService.GetAll();

            foreach (Menu menu in menus)
            {
                menusComboBox.Items.Add(menu.Title);
            }
        }

        private void menusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menusComboBox.Text != "")
            {
                GetProducts();
            }
        }

        private void productsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = productsDataGridView.SelectedCells[0].RowIndex;

            int columnOfInterest = 1;

            object cellValue = productsDataGridView.Rows[selectedRow].Cells[columnOfInterest].Value;

            selectedProductTextBox.Text = cellValue.ToString();
        }

        private void deletePictureBox_Click(object sender, EventArgs e)
        {
            if (selectedProductTextBox.Text != "")
            {
                //onay
                DialogResult result = Helper.ShowMessage("İşlemi onaylıyor musunuz?");
                if (result == DialogResult.Yes)
                {
                    ProductService productService = new ProductService();
                    if (productService.DeleteProduct(selectedProductTextBox.Text)) 
                    {
                        Helper.ShowMessage("Ürün silindi.", true);
                        GetProducts();
                    }
                    else { Helper.ShowMessage("İşlem başarısız.", false); }
                }
                else if (result == DialogResult.No) { Helper.ShowMessage("İşlem iptal edildi.", true); }
                else { Helper.ShowMessage("İşlem iptal edildi.", true); }
            }
        }

        private void GetProducts()
        {
            productsDataGridView.Rows.Clear();

            ProductService productService = new ProductService();

            List<Product> products = productService.GetProductsByMenu(menusComboBox.Text);


            foreach (Product product in products)
            {
                productsDataGridView.Rows.Add(product.Id, product.Name, product.UnitPrice, product.Menu, product.Stock, product.Description);
            }
        }
    }
}
