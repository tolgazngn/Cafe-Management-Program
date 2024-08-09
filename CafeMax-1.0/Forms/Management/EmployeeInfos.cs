using CafeMax.Business.Entity;
using CafeMax.Business.Service.concretes;
using DocumentFormat.OpenXml.Drawing.Charts;
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
    public partial class EmployeeInfos : Form
    {
        public EmployeeInfos()
        {
            InitializeComponent();
        }

        private void EmployeeInfos_Load(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (allRowsCheckBox.Checked)
            {
                GetAllEmployees();
            }
            else
            {
                GetEmployeesByName();
            }
        }

        private void GetAllEmployees()
        {
            employeeDataGridView.Rows.Clear();

            EmployeeService employeeService = new EmployeeService();

            List<Employee> employees = employeeService.GetAll();

            foreach (Employee employee in employees)
            {
                employeeDataGridView.Rows.Add(employee.Id, employee.Name, employee.Surname, employee.PhoneNumber, employee.Email, employee.Address, employee.DateOfEntry, employee.DateOfExit, BoolConvertToString(employee.IsActive));
            }
        }

        private void GetEmployeesByName()
        {
            employeeDataGridView.Rows.Clear();

            EmployeeService employeeService = new EmployeeService();

            List<Employee> employees = employeeService.GetEmployeesByName(searchTextBox.Text);

            foreach (Employee employee in employees)
            {
                employeeDataGridView.Rows.Add(employee.Id, employee.Name, employee.Surname, employee.PhoneNumber, employee.Email, employee.Address, employee.DateOfEntry, employee.DateOfExit, employee.IsActive, employee.Salary);
            }
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer basılan tuş harf değilse ve geri tuşu (Backspace) değilse girişe izin verme
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void employeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private string BoolConvertToString(bool value)
        {
            if (value) { return "Aktif"; } else { return "Aktif Değil"; }
        }
    }
}
