using CafeMax.Business.Entity;
using CafeMax.Business.Service.abstracts;
using CafeMax.Business.Service.concretes;
using CafeMax.Business.Util;
using CafeMax.DataAccess.order;
using CafeMax.DataAccess.orderdetail;
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
    public partial class NewOrder : Form
    {
        public NewOrder()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NewOrder_Load(object sender, EventArgs e)
        {
            RefreshFullTables();
            GetAllData();
        }

        private void menuComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            productDataGridView.Rows.Clear();
            selectedProductTextBox.Clear();

            ProductService productService = new ProductService();

            List<Product> products = productService.GetProductsByMenu(menuComboBox.Text);

            
            foreach (Product product in products)
            {
                productDataGridView.Rows.Add(product.Name, product.UnitPrice);
            }
        }
        

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = productDataGridView.SelectedCells[0].RowIndex;

            int columnOfInterest = 0;

            object cellValue = productDataGridView.Rows[selectedRow].Cells[columnOfInterest].Value;

            selectedProductTextBox.Text = cellValue.ToString();
        }

        private void enterPictureBox_Click(object sender, EventArgs e)
        {
            if (ObjectsIsNull()) { Helper.ShowMessage("Boş alan olmamalı!", false); }
            else
            {
                string productName = selectedProductTextBox.Text;
                decimal amount = amountNumericUpDown.Value;

                ProductService productService = new ProductService();
                Product product = productService.GetUnitPriceByName(productName);

                orderDataGridView.Rows.Add(productName, amount, amount * product.UnitPrice);


                amountNumericUpDown.Value = 1;
            }
        }

        private void deletePictureBox_Click(object sender, EventArgs e)
        {
            if (orderDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = orderDataGridView.SelectedRows[0];

                orderDataGridView.Rows.Remove(selectedRow);
            }
        }

        private void lastEnterPictureBox_Click(object sender, EventArgs e)
        {
            if (orderDataGridView.RowCount == 0)
            {
                Helper.ShowMessage("Boş alan olmamalı!", false);
            }
            else
            {
                int failedTransactionCount = 0;

                string tableName = fullTableComboBox.Text;

                SaleService saleService = new SaleService();

                OrderDetailService orderDetailService = new OrderDetailService();

                for (int i = 0; i < orderDataGridView.RowCount; i++)
                {
                    DataGridViewRow row = orderDataGridView.Rows[i];

                    object cell1Value = row.Cells[0].Value;
                    object cell2Value = row.Cells[1].Value;
                    object cell3Value = row.Cells[2].Value;

                    OrderDetail orderDetail = new OrderDetail();

                    orderDetail.ProductName = (string)cell1Value;
                    orderDetail.Amount = Convert.ToByte(cell2Value);

                    bool result = orderDetailService.AddOrderDetail(orderDetail, tableName);

                    decimal totalPrice = Convert.ToDecimal(cell3Value);

                    saleService.AddTotalPrice(tableName, totalPrice);

                    if (!result) 
                    {
                        Helper.ShowMessage($"{orderDetail.ProductName} ürünü eklenemedi!", false);
                        failedTransactionCount++;
                    }
                    
                }

                if (failedTransactionCount == 0) 
                {
                    Helper.ShowMessage("Tüm ürünler eklendi.", true);
                }

                ClearScreen();
                GetAllData();
            }
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void enterTablePictureBox_Click(object sender, EventArgs e)
        {
            if (emptyTableComboBox.Text == "")
            {
                Helper.ShowMessage("Boş alan olmamalıdır!", true);
            }
            else
            {
                string tableName = emptyTableComboBox.Text;

                if (tableName != "" || tableName != null)
                {
                    AccountService accountService = new AccountService();

                    if (accountService.Open(tableName))
                    {
                        Helper.ShowMessage("Masa açıldı.", true); 

                        RefreshEmptyTables();
                        RefreshFullTables();
                        ClearScreen();
                    }
                    else
                    {
                        Helper.ShowMessage("Masa açılamadı.", false);
                    }
                }
                else
                {
                    Helper.ShowMessage("Masa seçiniz.", false); 
                }
                
            }
            

        }

        private void fullTableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearScreen();
            GetAllData();
        }

        private void ClearScreen()
        {
            productDataGridView.Rows.Clear();

            selectedProductTextBox.Clear();

            amountNumericUpDown.Value = 1;

            orderDataGridView.Rows.Clear();
        }

        private void GetAllData()
        {
            RefreshEmptyTables();
            RefreshMenus();
        }

        private void RefreshFullTables()
        {
            fullTableComboBox.Items.Clear();

            TableService tableService = new TableService();

            List<Table> fullTables = tableService.GetFulls();

            foreach (Table table in fullTables)
            {
                fullTableComboBox.Items.Add(table.Name);
            }
        }

        private void RefreshEmptyTables()
        {
            emptyTableComboBox.Text = "";
            emptyTableComboBox.Items.Clear();

            TableService tableService = new TableService();

            List<Table> emptyTables = tableService.GetEmpties();

            foreach (Table table in emptyTables)
            {
                emptyTableComboBox.Items.Add(table.Name);
            }
        }

        private void RefreshMenus()
        {
            menuComboBox.Items.Clear();

            MenuService menuService = new MenuService();

            List<Menu> menus = menuService.GetAll();

            foreach (Menu menu in menus)
            {
                menuComboBox.Items.Add(menu.Title);
            }
        }

        private bool ObjectsIsNull()
        {
            if (productDataGridView.RowCount == 0 || selectedProductTextBox.Text == "")
            {
                return true;
            }
            else { return false; }
        }


    }
}
