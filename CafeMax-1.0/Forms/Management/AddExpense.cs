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
    public partial class AddExpense : Form
    {
        private string Username = ManagementPanel.Username;
        private Employee Employee;

        public AddExpense()
        {
            InitializeComponent();
        }


        private void AddExpense_Load(object sender, EventArgs e)
        {
            var employeeService = new EmployeeService();

            Employee = employeeService.GetEmployeeByUsername(Username);

            RefreshWindow();
            RefreshExpenseTable();
        }

        private void RefreshWindow()
        {
            PaymentMethodService paymentMethodService = new PaymentMethodService();

            List<PaymentMethod> paymentMethods = paymentMethodService.GetAll();

            foreach (PaymentMethod paymentMethod in paymentMethods)
            {
                paymentTypeComboBox.Items.Add(paymentMethod.Title);
            }
        }

        private void enterPictureBox_Click(object sender, EventArgs e)
        {
            if (typeTextBox.Text != "" && paidTextBox.Text != "" && paymentTypeComboBox.Text != "" && amountNumericUpDown.Value != 0)
            {
                Expense expense = new Expense();

                expense.Type = typeTextBox.Text;
                expense.Amount = (short)amountNumericUpDown.Value;
                expense.Description = descriptionRichTextBox.Text;
                expense.Paid = Convert.ToDecimal(paidTextBox.Text);
                expense.PaymentMethod = paymentTypeComboBox.Text;
                expense.EmployeeId = Employee.Id;

                ExpenseService expenseService = new ExpenseService();

                if (expenseService.AddExpense(expense))
                {
                    Helper.ShowMessage("Gider eklendi", true);

                    RefreshExpenseTable();

                    typeTextBox.Clear();
                    amountNumericUpDown.Value = 1;
                    descriptionRichTextBox.Clear();
                    paidTextBox.Clear();
                    paymentTypeComboBox.Text = "";
                }
                else { Helper.ShowMessage("Gider eklenemdi.", false); }
            }
            else { Helper.ShowMessage("Açıklama hariç boş alan olmamalıdır.", false); }
        }

        private void RefreshExpenseTable()
        {
            expensesDataGridView.Rows.Clear();

            ExpenseService expenseService = new ExpenseService();

            List<Expense> expenses = expenseService.GetAll();

            foreach (Expense expense in expenses)
            {
                expensesDataGridView.Rows.Add(expense.Type, expense.Amount, expense.Description, expense.Paid, expense.PaymentMethod, expense.EmployeeFullName, expense.Date);
            }
        }

        private void paidTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer basılan tuş rakam değilse ve geri tuşu (Backspace) değilse girişe izin verme
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
