using CafeMax.Business.Entity;
using CafeMax.Business.Service.concretes;
using CafeMax.Business.Util;
using CafeMax.Forms;
using CafeMax.Forms.Management;
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
    public partial class ManagementPanel : Form
    {
        private Form activeForm;
        private Button selectedButton;

        public static string Username;
        private static Employee Employee;
        public static string FullName;

        public static bool UserProfileIsOpen = false;

        public ManagementPanel()
        {
            InitializeComponent();
        }

        public ManagementPanel(string username)
        {
            InitializeComponent();
            Username = username;
            Helper.OpenPages += 1;
        }

        private void tableInfosButton_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(tableInfosButton);
            selectedButton = tableInfosButton;

            titleLabel.Text = "Masa Bilgileri";

            OpenChildForm(new TableInfos(), sender);
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(ordersButton);
            selectedButton = ordersButton;

            titleLabel.Text = "Siparişler";

            OpenChildForm(new AllOrders(), sender);
        }

        private void salesButton_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(salesButton);
            selectedButton = salesButton;

            titleLabel.Text = "Satışlar";

            OpenChildForm(new AllSales(), sender);
        }

        private void employeeInfosButton_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(employeeInfosButton);
            selectedButton = employeeInfosButton;

            titleLabel.Text = "Personel Bilgileri";

            OpenChildForm(new EmployeeInfos(), sender);
        }

        private void employeeOperationsButton_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(employeeOperationsButton);
            selectedButton = employeeOperationsButton;

            titleLabel.Text = "Personel İşlemleri";

            OpenChildForm(new EmployeeOperations(), sender);
        }

        private void productInfosButton_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(productInfosButton);
            selectedButton = productInfosButton;

            titleLabel.Text = "Ürün Bilgileri";

            OpenChildForm(new ProductInfos(), sender);
        }

        private void productOperationsButton_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(productOperationsButton);
            selectedButton = productOperationsButton;

            titleLabel.Text = "Ürün İşlemleri";

            OpenChildForm(new ProductOperations(), sender);
        }
        private void expensesButton_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(expensesButton);
            selectedButton = expensesButton;

            titleLabel.Text = "Giderler";

            OpenChildForm(new Expenses(), sender);
        }

        private void addExpenseButton_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(addExpenseButton);
            selectedButton = addExpenseButton;

            titleLabel.Text = "Gider Ekle";

            OpenChildForm(new AddExpense(), sender);
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

        private void ManagementPanel_Load(object sender, EventArgs e)
        {
            var employeeService = new EmployeeService();

            Employee = employeeService.GetEmployeeByUsername(Username);
            FullName = Employee.GetFullName();

            fullNameLabel.Text = Employee.GetFullName();
            jobLabel.Text = Employee.Job;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //profil sayfası açık değilse çalışır
            if (!UserProfileIsOpen)
            {
                UserProfile userProfile = new UserProfile(Username);
                userProfile.Show();
                UserProfileIsOpen = true;
            }
        }

        private void userOperationsButton_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(userOperationsButton);
            selectedButton = userOperationsButton;

            titleLabel.Text = "Kullanıcı İşlemleri";

            OpenChildForm(new UserOperations(), sender);
        }

        private void menuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ManagementPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Helper.OpenPages == 1)
            {

                Application.Exit();
            }
            else { Helper.OpenPages -= 1; }
        }
    }
}
