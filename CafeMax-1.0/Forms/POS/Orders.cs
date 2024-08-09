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
    public partial class Orders : Form
    {
        private int selectedOrderId;
        public Orders()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Orders_Load(object sender, EventArgs e)
        {
            RefreshWindow();
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
                orderDetailsDataGridView.Rows.Clear();
                GetOrderDetails(tableName);
            }
        }

        private void RefreshWindow()
        {
            tableComboBox.Items.Clear();

            ordersDataGridView.Rows.Clear();

            orderDetailsDataGridView.Rows.Clear();

            OrderService orderService = new OrderService();

            List<Order> orders = orderService.GetOpenOrders();

            foreach (Order order in orders)
            {
                ordersDataGridView.Rows.Add(order.Code, order.TableName, order.Date, BoolConvertToString(order.Status));
            }

            TableService tableService = new TableService();

            List<Table> tables = tableService.GetFulls();

            foreach (Table table in tables)
            {
                tableComboBox.Items.Add(table.Name);
            }
        }

        private void GetOrderDetails(string tableName)
        {
            OrderDetailService orderDetailService = new OrderDetailService();

            List<OrderDetail> orderDetails = orderDetailService.GetOrderDetailsByTableName(tableName);

            foreach (OrderDetail orderDetail in orderDetails)
            {
                orderDetailsDataGridView.Rows.Add(orderDetail.Id, orderDetail.ProductName, orderDetail.Amount, orderDetail.UnitPrice, orderDetail.TotalPrice);
            }
        }

        private string BoolConvertToString(bool value)
        {
            if (value) { return "Açık"; } else { return "Kapalı"; }
        }



        private void orderDetailsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = orderDetailsDataGridView.SelectedCells[0].RowIndex;

            int columnOfInterest = 1;

            object cellValue = orderDetailsDataGridView.Rows[selectedRow].Cells[columnOfInterest].Value;


            object cellValue2 = orderDetailsDataGridView.Rows[selectedRow].Cells[0].Value;

            selectedOrderId = (int)cellValue2;
        }

        private void productCancellationButton_Click(object sender, EventArgs e)
        {
            AccountService accountService = new AccountService();

            DialogResult result = Helper.ShowMessage($"Seçili ürünü iptal etmek istiyor musunuz?");
            if (result == DialogResult.Yes)
            {
                if (orderDetailsDataGridView.SelectedRows.Count > 0)
                {
                    var orderDetailId = Convert.ToInt32(orderDetailsDataGridView.SelectedRows[0].Cells[0].Value);

                    if (accountService.ProductCancellation(orderDetailId))
                    {
                        Helper.ShowMessage("İşlem başarılı.", true);

                        RefreshWindow();
                    }
                    else { Helper.ShowMessage("İşlem başarısız.", false); }
                }
            }
            else if (result == DialogResult.No) { Helper.ShowMessage("İşlem iptal edildi.", true); }
            else { Helper.ShowMessage("İşlem iptal edildi.", true); }
        }
    }
}
