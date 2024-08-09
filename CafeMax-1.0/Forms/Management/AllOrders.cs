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
    public partial class AllOrders : Form
    {
        public AllOrders()
        {
            InitializeComponent();
        }

        private void AllOrders_Load(object sender, EventArgs e)
        {

        }

        private void searchOrdersPictureBox_Click(object sender, EventArgs e)
        {
            if (allRowsCheckBox.Checked)
            {
                orderDetailsDataGridView.Rows.Clear();
                GetAllOrders();
            }
            else
            {
                orderDetailsDataGridView.Rows.Clear();
                GetOrdersByDate();
            }
        }

        private void GetAllOrders()
        {
            ordersDataGridView.Rows.Clear();

            OrderService orderService = new OrderService();

            List<Order> orders = orderService.GetAll();

            foreach (Order order in orders)
            {
                ordersDataGridView.Rows.Add(order.Code, order.TableName, Helper.StatusToString(order.Status), order.Date);
            }
        }

        private void GetOrdersByDate()
        {
            ordersDataGridView.Rows.Clear();

            OrderService orderService = new OrderService();

            List<Order> orders = orderService.GetOrdersByDate(firstDateTimePicker.Value, secondDateTimePicker.Value);

            foreach (Order order in orders)
            {
                ordersDataGridView.Rows.Add(order.Code, order.TableName, Helper.StatusToString(order.Status), order.Date);
            }
        }

        private void GetOrderDetailsByOrderId(Guid orderCode)
        {
            orderDetailsDataGridView.Rows.Clear();

            OrderDetailService orderDetailService = new OrderDetailService();

            List<OrderDetail> orderDetails = orderDetailService.GetOrderDetailsByOrderId(orderCode);

            foreach (OrderDetail orderDetail in orderDetails)
            {
                orderDetailsDataGridView.Rows.Add(orderDetail.ProductName, orderDetail.Amount, orderDetail.UnitPrice, orderDetail.UnitPrice * orderDetail.Amount);
            }
        }

        private void ordersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = ordersDataGridView.SelectedCells[0].RowIndex;

            int columnOfInterest = 0;

            object cellValue = ordersDataGridView.Rows[selectedRow].Cells[columnOfInterest].Value;

            GetOrderDetailsByOrderId((Guid)cellValue);
        }
    }
}
