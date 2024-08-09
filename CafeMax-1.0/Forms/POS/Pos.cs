using Azure.Identity;
using CafeMax.Business.Entity;
using CafeMax.Business.Service.concretes;
using CafeMax.Business.Util;
using CafeMax.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using Microsoft.Web.WebView2.Core;

namespace CafeMax
{
    public partial class Pos : Form
    {
        private Form activeForm;
        private Button selectedButton;
        private string Username;
        private Employee Employee;
        public static bool UserProfileIsOpen = false;

        public Pos()
        {
            InitializeComponent();
        }

        public Pos(string username)
        {
            InitializeComponent();
            Username = username;
            Employee = new Employee();
            label2.Text = $"Hoşgeldin {username}";
        }

        private void tableOperationsButton_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(tableOperationsButton);
            selectedButton = tableOperationsButton;

            titleLabel.Text = "Masa Siparişleri";

            OpenChildForm(new TableOperations(), sender);
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ordersButton);
            selectedButton = ordersButton;

            titleLabel.Text = "Siparişler";

            OpenChildForm(new Orders(), sender);
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(newOrderButton);
            selectedButton = newOrderButton;

            titleLabel.Text = "Yeni Sipariş";

            OpenChildForm(new NewOrder(), sender);
        }

        private void getPaidButton_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(getPaidButton);
            selectedButton = getPaidButton;

            titleLabel.Text = "Ödeme Al";

            OpenChildForm(new GetPaid(), sender);
        }

        private void salesButton_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(salesButton);
            selectedButton = salesButton;

            titleLabel.Text = "Satışlar";

            OpenChildForm(new Sales(), sender);
        }

        private void stockTrackingButton_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(stockTrackingButton);
            selectedButton = stockTrackingButton;

            titleLabel.Text = "Stok Takip";

            OpenChildForm(new StockTracking(Employee.Job), sender);
        }

        private void OpenChildForm(Form childForm, object buttonSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(childForm);
            this.mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ChangeButtonColor(Button Button)
        {
            if (selectedButton != null)
            {
                selectedButton.BackColor = ColorTranslator.FromHtml("#1B618C");
            }
            Button.BackColor = ColorTranslator.FromHtml("#083A59");
        }



        private void Pos_Load(object sender, EventArgs e)
        {
            var employeeService = new EmployeeService();

            Employee = employeeService.GetEmployeeByUsername(Username);

            fullNameLabel.Text = Employee.GetFullName();
            jobLabel.Text = Employee.Job;

            Helper.OpenPages += 1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!UserProfileIsOpen)
            {
                UserProfile userProfile = new UserProfile(Username);
                userProfile.Show();
                UserProfileIsOpen = true;
            }
        }

        private void menuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Employee.Job == "Yönetici")
            {
                var managementPanel = new ManagementPanel(Username);
                managementPanel.Show();
            }
            else { Helper.ShowMessage("Yetkiniz bulunmamaktadır.", false); }
        }

        private void Pos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Helper.OpenPages == 1)
            {

                Application.Exit();
            }
            else { Helper.OpenPages -= 1; }
        }

        private void zReportButton_Click(object sender, EventArgs e)
        {
            DialogResult result = Helper.ShowMessage("Z raporu almak istiyor musunuz?");
            if (result == DialogResult.Yes)
            {
                WordDocumentService wordDocumentService = new WordDocumentService();

                wordDocumentService.CreateZRaport(Username);

                Helper.ShowMessage("Rapor kaydedildi.", true);
            }
            else if (result == DialogResult.No) { Helper.ShowMessage("İşlem iptal edildi.", true); }
            else { Helper.ShowMessage("İşlem iptal edildi.", true); }
        }
        
    }
}
