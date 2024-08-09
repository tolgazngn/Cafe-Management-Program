using CafeMax.Business.Entity;
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

namespace CafeMax
{
    public partial class StockTracking : Form
    {
        private string Job = "";

        public StockTracking(string job)
        {
            InitializeComponent();

            Job = job;
        }

       

        private void label6_Click(object sender, EventArgs e)
        {

        }



        private void StockTracking_Load(object sender, EventArgs e)
        {
            RefreshMenus();
        }

        private void menusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshProductTable();
        }

        private void stockDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = stockDataGridView.SelectedCells[0].RowIndex;

            int columnOfInterest = 0;

            object cellValue = stockDataGridView.Rows[selectedRow].Cells[columnOfInterest].Value;

            selectedProductTextBox.Text = cellValue.ToString();
        }

        private void enterPictureBox_Click(object sender, EventArgs e)
        {
            if (Job == "Yönetici")
            {
                if (selectedProductTextBox.Text == "")
                {
                    Helper.ShowMessage("Ürün seçiniz.", false);
                }
                else
                {
                    ProductService productService = new ProductService();

                    if (productService.AddStock(selectedProductTextBox.Text, (short)amountNumericUpDown.Value))
                    {
                        Helper.ShowMessage("Stok güncellendi.", true);
                        RefreshProductTable();
                    }
                    else
                    {
                        Helper.ShowMessage("İşlem başarısız.", false);
                    }
                }
            }
            else { Helper.ShowMessage("Bu işlem için yetkiniz bulunmamaktadır.", false); }
        }

        private void RefreshMenus()
        {
            MenuService menuService = new MenuService();

            List<Menu> menus = menuService.GetAll();

            foreach (Menu menu in menus)
            {
                menusComboBox.Items.Add(menu.Title);
            }
        }

        private void RefreshProductTable()
        {
            stockDataGridView.Rows.Clear();

            ProductService productService = new ProductService();

            List<Product> products = productService.GetProductsByMenu(menusComboBox.Text);

            foreach (Product product in products)
            {
                stockDataGridView.Rows.Add(product.Name, product.Menu, product.UnitPrice, product.Stock);
            }
        }
    }
}
