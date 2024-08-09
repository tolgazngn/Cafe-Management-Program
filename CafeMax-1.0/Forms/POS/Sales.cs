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

namespace CafeMax
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void searchDetailsPictureBox_Click(object sender, EventArgs e)
        {
            string tableName = tableComboBox.Text;

            if (tableName == "")
            {
                Helper.ShowMessage("Lütfen masa seçiniz.", false);
            }
            else
            {
                paymentActivitiesDataGridView.Rows.Clear();
                GetOrderDetails(tableName);
            }
        }

        private void GetOrderDetails(string tableName)
        {
            PaymentService paymentService = new PaymentService();

            List<Payment> payments = paymentService.GetPaymentsByTableName(tableName);

            foreach (Payment payment in payments)
            {
                paymentActivitiesDataGridView.Rows.Add(payment.Code, payment.Paid, payment.PaymentMethod, payment.Date);
            }
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            RefreshWindow();
        }

        private void RefreshWindow()
        {
            salesDataGridView.Rows.Clear();
            paymentActivitiesDataGridView.Rows.Clear();

            fullTableComboBox.Items.Clear();
            fullTableComboBox.Text = "";

            discountTotalTextBox.Text = "";

            tableComboBox.Text = "";
            tableComboBox.Items.Clear();

            SaleService saleService = new SaleService();

            List<Sale> sales = saleService.GetOpenSales();

            foreach (Sale sale in sales)
            {

                salesDataGridView.Rows.Add(sale.Code, sale.TableName, sale.Discount, sale.TotalPrice, sale.TotalPaid, BoolConvertToString(sale.Status), sale.Date);
            }

            TableService tableService = new TableService();

            List<Table> tables = tableService.GetFulls();

            foreach (Table table in tables)
            {
                tableComboBox.Items.Add(table.Name);
                fullTableComboBox.Items.Add(table.Name);
            }
        }

        private string BoolConvertToString(bool value)
        {
            if (value) { return "Açık"; } else { return "Kapalı"; }
        }

        private void discountTotalTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer basılan tuş rakam değilse ve geri tuşu (Backspace) değilse girişe izin verme
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void discountTotalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            if (discountTotalTextBox.Text != "" && fullTableComboBox.Text != "")
            {
                DialogResult result = Helper.ShowMessage($"İndirim eklemek istiyor musunuz?");
                if (result == DialogResult.Yes)
                {
                    SaleService saleService = new SaleService();
                    Sale sale = saleService.GetSaleByTableName(fullTableComboBox.Text);

                    if (sale.TotalPrice > Convert.ToDecimal(discountTotalTextBox.Text))
                    {
                        AccountService accountService = new AccountService();

                        if (accountService.AddDiscount(fullTableComboBox.Text, Convert.ToDecimal(discountTotalTextBox.Text)))
                        {
                            Helper.ShowMessage("İndirim eklendi.", true);
                            RefreshWindow();
                        }
                        else { Helper.ShowMessage("İşlem başarısız.", false); }
                    }
                    else { Helper.ShowMessage("İndirim tutarı hesap ücretini aşıyor.", false); }
                }
                else if (result == DialogResult.No) { Helper.ShowMessage("İşlem iptal edildi.", true); }
                else { Helper.ShowMessage("İşlem iptal edildi.", true); }

                
            }
            else { Helper.ShowMessage("Boş alan olmamalı.", false); }
        }

        private void DeleteDiscountButton_Click(object sender, EventArgs e)
        {
            DialogResult result = Helper.ShowMessage($"Seçili masanın indirimini iptal etmek istiyor musunuz?");
            if (result == DialogResult.Yes)
            {
                AccountService accountService = new AccountService();

                 if (accountService.DeleteDiscount(fullTableComboBox.Text))
                 {
                        Helper.ShowMessage("İndirim silindi.", true);
                        RefreshWindow();
                 }
                 else { Helper.ShowMessage("İşlem başarısız.", false); }
            }
            else if (result == DialogResult.No) { Helper.ShowMessage("İşlem iptal edildi.", true); }
            else { Helper.ShowMessage("İşlem iptal edildi.", true); }


        }
    }
}
