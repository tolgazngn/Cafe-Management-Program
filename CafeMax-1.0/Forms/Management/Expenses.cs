using CafeMax.Business.Entity;
using CafeMax.Business.Service.concretes;
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
    public partial class Expenses : Form
    {
        public Expenses()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            ExpenseService expenseService = new ExpenseService();

            if (allRowsCheckBox.Checked)
            {
                GetAllExpenses();
            }
            else
            {
                GetExpensesByDate();
            }
        }
        private void GetAllExpenses()
        {
            expensesDataGridView.Rows.Clear();

            ExpenseService expenseService = new ExpenseService();

            List<Expense> expenses = expenseService.GetAll();

            foreach (Expense expense in expenses)
            {
                expensesDataGridView.Rows.Add(expense.Type, expense.Amount, expense.Description, expense.Paid, expense.PaymentMethod, expense.EmployeeFullName, expense.Date);
            }
        }

        private void GetExpensesByDate()
        {
            expensesDataGridView.Rows.Clear();

            ExpenseService expenseService = new ExpenseService();

            List<Expense> expenses = expenseService.GetExpensesByDate(firstDateTimePicker.Value, secondDateTimePicker.Value);

            foreach (Expense expense in expenses)
            {
                expensesDataGridView.Rows.Add(expense.Type, expense.Amount, expense.Description, expense.Paid, expense.PaymentMethod, expense.EmployeeFullName, expense.Date);
            }
        }

        private void Expenses_Load(object sender, EventArgs e)
        {

        }
    }
}
