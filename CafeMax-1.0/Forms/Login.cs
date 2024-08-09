
using CafeMax.Business.Entity;
using CafeMax.Business.Service.abstracts;
using CafeMax.Business.Service.concretes;
using CafeMax.Business.Util;
using CafeMax.DataAccess.employee;
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
    public partial class Login : Form
    {
        Employee Employee;

        public Login()
        {
            InitializeComponent();

            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            
        }


        private void enter_Click(object sender, EventArgs e)
        {
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;

            AuthenticationService authenticationService = new AuthenticationService();
            ValidationService validationService = new ValidationService();

            if (validationService.isValidUsername(userNameTextBox.Text) && validationService.isValidPassword(password))
            {
                bool result = authenticationService.LoginUser(username, password);
                if (result) 
                {
                    EmployeeService employeeService = new EmployeeService();
                    Employee = employeeService.GetEmployeeByUsername(username);

                    Form pos = new Pos(username); 
                    pos.Show(); 
                    this.Hide(); 
                }
                else { Helper.ShowMessage("Yanlış kullanıcı adı veya şifre!", false); }
            }
            else { Helper.ShowMessage("Eksik veya hatalı veri girişi!", false); }
            
        }

        
    }
}
