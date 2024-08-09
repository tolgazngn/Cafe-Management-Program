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
    public partial class GetPaid : Form
    {
        decimal totalPrice;
        Sale sale;
        Order order;

        public GetPaid()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void enter_Click(object sender, EventArgs e)
        {
            //veri alanacak form nesnelerinin boş bırakılması kontrolü
            if (tableComboBox.Text != "" && paymentTypeComboBox.Text != "" && paymentTotalTextBox.Text != "" && paymentTotalTextBox.Text != "0" && paidTextBox == null)
            {
                if (Convert.ToDecimal(paymentTotalTextBox.Text) > Convert.ToDecimal(remainderTextBox.Text))
                {
                    Helper.ShowMessage("Ödeme kalan hesaptan tutarından fazla olamaz.", false);
                    return;
                }

                DialogResult result = Helper.ShowMessage($"Ödeme işlemini onaylıyor musunuz?");
                if (result == DialogResult.Yes)
                {
                    PaidOperation();
                }
                else if (result == DialogResult.No) { Helper.ShowMessage("İşlem iptal edildi.", true); }
                else { Helper.ShowMessage("İşlem iptal edildi.", true); }
            }
            else { Helper.ShowMessage("Boş alan olmamalıdır.", false); }
        }

        private void GetPaid_Load(object sender, EventArgs e)
        {
            GetFullTables();
            GetPaymentMethods();
        }

        private void tableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            GetPayments();
            GetOrderDetails();
            GetSale();

        }



        private void allPaymentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (allPaymentCheckBox.Checked)
            {
                paymentTotalTextBox.Clear();
                paymentTotalTextBox.ReadOnly = true;
                paymentTotalTextBox.Text = totalPrice.ToString();
            }
            else
            {
                paymentTotalTextBox.ReadOnly = false;
                paymentTotalTextBox.Text = "";
            }
        }




        private void GetFullTables()
        {
            tableComboBox.Text = "";
            tableComboBox.Items.Clear();

            TableService tableService = new TableService();

            List<Table> fullTables = tableService.GetFulls();

            foreach (Table table in fullTables)
            {
                tableComboBox.Items.Add(table.Name);
            }
        }

        private void GetPaymentMethods()
        {
            paymentTypeComboBox.Text = "";
            paymentTypeComboBox.Items.Clear();

            PaymentMethodService paymentMethodService = new PaymentMethodService();

            List<PaymentMethod> paymentMethods = paymentMethodService.GetAll();

            foreach (PaymentMethod paymentMethod in paymentMethods)
            {
                paymentTypeComboBox.Items.Add(paymentMethod.Title);
            }
        }

        private void GetPayments()
        {
            PaymentService paymentService = new PaymentService();
            List<Payment> payments = paymentService.GetPaymentsByTableName(tableComboBox.Text);

            foreach (Payment payment in payments)
            {
                receivedPaymentsDataGridView.Rows.Add(payment.Paid, payment.Date);
            }
        }

        private void GetOrderDetails()
        {
            orderDetailsDataGridView.Rows.Clear();

            OrderService orderService = new OrderService();
            Order order = orderService.GetOrderByTableName(tableComboBox.Text);

            OrderDetailService orderDetailService = new OrderDetailService();
            List<OrderDetail> orderDetails = orderDetailService.GetOrderDetailsByTableName(tableComboBox.Text);

            foreach (OrderDetail orderDetail in orderDetails)
            {
                orderDetailsDataGridView.Rows.Add(order.TableName, orderDetail.ProductName, orderDetail.Amount, orderDetail.TotalPrice, order.Date);
            }
        }

        private void GetSale()
        {
            SaleService saleService = new SaleService();
            Sale sale = saleService.GetSaleByTableName(tableComboBox.Text);

            totalPrice = sale.TotalPrice - (sale.TotalPaid + sale.Discount);

            totalTextBox.Text = sale.TotalPrice.ToString();
            paidTextBox.Text = sale.TotalPaid.ToString();
            remainderTextBox.Text = (sale.TotalPrice - (sale.TotalPaid + sale.Discount)).ToString();

            discountTextBox.Text = sale.Discount.ToString();
        }

        private void PaidOperation()
        {
            //kullanılacak servis örneklerini oluşturma
            AccountService accountService = new AccountService();


            if (accountService.GetPaid(tableComboBox.Text, Convert.ToDecimal(paymentTotalTextBox.Text), paymentTypeComboBox.Text))
            {
                Helper.ShowMessage("Ödeme alındı.", true);

                //yapılan işlemlerden sonra sayfadaki bilgileri yenileme
                GetPayments();
                GetOrderDetails();
                GetSale();

                paymentTotalTextBox.Clear();

                //kalan ücret bilgisini alıyoruz
                decimal remainder = Convert.ToDecimal(remainderTextBox.Text);

                //eğer kalan sıfırsa hesap kapanmalıdır
                if (remainder == 0)
                {
                    //mevcut hesabı sırasıyla kapatma işlemi
                    bool result = accountService.Close(tableComboBox.Text);

                    if (accountService.Close(tableComboBox.Text))
                    {
                        Helper.ShowMessage("Hesap kapatıldı.", true);

                        allPaymentCheckBox.Checked = false;

                        GetFullTables();
                        GetPaymentMethods();

                        GetPayments();
                        GetOrderDetails();
                        GetSale();
                    }
                    else { Helper.ShowMessage("Hesap kapatılamadı.", true); }
                }
            }
            else { Helper.ShowMessage("İşlem başarısız.", false); }
        }

        private void paymentTotalTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer basılan tuş rakam değilse ve geri tuşu (Backspace) değilse girişe izin verme
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void paymentTotalTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void getPaidPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
