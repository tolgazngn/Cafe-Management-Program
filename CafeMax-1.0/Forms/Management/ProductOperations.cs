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

namespace CafeMax.Forms.Management
{
    public partial class ProductOperations : Form
    {
        public ProductOperations()
        {
            InitializeComponent();
        }

        private void ProductOperations_Load(object sender, EventArgs e)
        {
            MenuService menuService = new MenuService();

            List<Menu> menus = menuService.GetAll();

            foreach (Menu menu in menus)
            {
                menuComboBox.Items.Add(menu.Title);
                menusComboBox.Items.Add(menu.Title);
            }
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && unitPriceTextBox.Text != "" && menuComboBox.Text != "")
            {
                ProductService productService = new ProductService();

                if (!productService.CheckProductNameAvailability(nameTextBox.Text))
                {
                    //onay
                    DialogResult result = Helper.ShowMessage("İşlemi onaylıyor musunuz?");
                    if (result == DialogResult.Yes)
                    {
                        Product product = new Product();
                        product.Name = nameTextBox.Text;
                        product.UnitPrice = Convert.ToDecimal(unitPriceTextBox.Text);
                        product.Menu = menuComboBox.Text;

                        if (productService.AddProduct(product))
                        {
                            Helper.ShowMessage("Ürün eklendi.", true);
                            nameTextBox.Clear();
                            unitPriceTextBox.Clear();
                        }
                        else { Helper.ShowMessage("İşlem başarısız.", false); }
                    }
                    else if (result == DialogResult.No) { Helper.ShowMessage("İşlem iptal edildi.", true); }
                    else { Helper.ShowMessage("İşlem iptal edildi.", true); }
                }
                else { Helper.ShowMessage("Ürün zaten var.", false); }
            }
            else { Helper.ShowMessage("Boş alan olmamalıdır.", false); }
        }

        private void menusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetProducts();
        }

        private void GetProducts()
        {
            productComboBox.Items.Clear();

            ProductService productService = new ProductService();

            List<Product> products = productService.GetProductsByMenu(menusComboBox.Text);


            foreach (Product product in products)
            {
                productComboBox.Items.Add(product.Name);
            }
        }

        private void enterUpdateUnitPrice_Click(object sender, EventArgs e)
        {
            if (productComboBox.Text != "" && newPriceTextBox.Text != "")
            {
                //onay
                DialogResult result = Helper.ShowMessage("İşlemi onaylıyor musunuz?");
                if (result == DialogResult.Yes)
                {
                    ProductService productService = new ProductService();

                    if (productService.ChangeUnitPrice(productComboBox.Text, Convert.ToDecimal(newPriceTextBox.Text)))
                    {
                        Helper.ShowMessage("Fiyat güncellendi.", true);
                        productComboBox.Text = "";
                        newPriceTextBox.Clear();
                    }
                    else { Helper.ShowMessage("İşlem başarısız.", false); }
                }
                else if (result == DialogResult.No) { Helper.ShowMessage("İşlem iptal edildi.", true); }
                else { Helper.ShowMessage("İşlem iptal edildi.", true); }
            }
            else { Helper.ShowMessage("Boş alan olmamalıdır.", false); }
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer basılan tuş harf değilse ve geri tuşu (Backspace) değilse girişe izin verme
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void unitPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer basılan tuş rakam değilse ve geri tuşu (Backspace) değilse girişe izin verme
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void newPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer basılan tuş rakam değilse ve geri tuşu (Backspace) değilse girişe izin verme
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void addProductPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
