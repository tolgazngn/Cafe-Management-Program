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
    public partial class AllSales : Form
    {
        public AllSales()
        {
            InitializeComponent();
        }

        private void searchPictureBox_Click(object sender, EventArgs e)
        {
            SaleService saleService = new SaleService();

            if (allRowsCheckBox.Checked)
            {
                paymentsDataGridView.Rows.Clear();
                GetAllSales();
            }
            else
            {
                paymentsDataGridView.Rows.Clear();
                GetSalesByDate();
            }
        }

        private void GetAllSales()
        {
            salesDataGridView.Rows.Clear();

            SaleService saleService = new SaleService();

            List<Sale> sales = saleService.GetAll();

            foreach (Sale sale in sales)
            {
                salesDataGridView.Rows.Add(sale.Code, sale.TableName, sale.Discount, sale.TotalPrice, sale.TotalPaid, Helper.StatusToString(sale.Status), sale.Date);
            }
        }

        private void GetSalesByDate()
        {
            salesDataGridView.Rows.Clear();

            SaleService saleService = new SaleService();

            List<Sale> sales = saleService.GetSalesByDate(firstDateTimePicker.Value, secondDateTimePicker.Value);

            foreach (Sale sale in sales)
            {
                salesDataGridView.Rows.Add(sale.Code, sale.TableName, sale.Discount, sale.TotalPrice, sale.TotalPaid, Helper.StatusToString(sale.Status), sale.Date);
            }
        }

        private void GetPaymentsBySaleId(Guid saleCode)
        {
            paymentsDataGridView.Rows.Clear();

            PaymentService paymentService = new PaymentService();

            List<Payment> payments = paymentService.GetPaymentsBySaleId(saleCode);

            foreach (Payment payment in payments)
            {
                paymentsDataGridView.Rows.Add(payment.Paid, payment.PaymentMethod, payment.Date);
            }
        }

        private void salesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = salesDataGridView.SelectedCells[0].RowIndex;

            int columnOfInterest = 0;

            object cellValue = salesDataGridView.Rows[selectedRow].Cells[columnOfInterest].Value;

            GetPaymentsBySaleId((Guid)cellValue);
        }

        private void AllSales_Load(object sender, EventArgs e)
        {

        }
    }
}
