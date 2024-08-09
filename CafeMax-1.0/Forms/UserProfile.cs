using CafeMax.Business.Entity;
using CafeMax.Business.Service.concretes;
using CafeMax.Business.Util;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeMax.Forms
{
    public partial class UserProfile : Form
    {
        private Employee Employee;
        private string Username;

        EmployeeService employeeService = new EmployeeService();

        //Karakter kontrolü için validation servisini referans alır.
        ValidationService validationService = new ValidationService();

        //Gerekli kontrolleri ve operasyonları gerçekleştirmek için user servisini referans alır.
        UserService userService = new UserService();

        AuthenticationService authenticationService = new AuthenticationService();

        public UserProfile()
        {
            InitializeComponent();
        }

        public UserProfile(string username)
        {
            InitializeComponent();
            Username = username;
            Employee = new Employee();
            Helper.OpenPages += 1;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            Employee = employeeService.GetEmployeeByUsername(Username);

            fullNameLabel.Text = Employee.GetFullName() + " - " + Employee.Username;
            jobLabel.Text = Employee.Job;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void enterPictureBox2_Click(object sender, EventArgs e)
        {
            if (currentPasswordTextBox.Text != "" && newPasswordTextBox.Text != "" && repeatPasswordTextBox.Text != "")
            {
                if (newPasswordTextBox.Text == repeatPasswordTextBox.Text)
                {
                    if (validationService.isValidPassword(newPasswordTextBox.Text))
                    {
                        if (authenticationService.LoginUser(Username, currentPasswordTextBox.Text))
                        {
                            if (userService.ChangePassword(Username, newPasswordTextBox.Text))
                            {
                                Helper.ShowMessage("Şifre başarıyla değiştirildi. Program yeniden başlatılacak.", true);
                                Application.Restart();
                            }
                            else { Helper.ShowMessage("Şifre değiştirme başarısız.", false); }
                        }
                        else { Helper.ShowMessage("Yanlış şifre.", false); }
                    }
                    else { Helper.ShowMessage("Şifre en az 6 karakter olmalıdır.", false); }
                }
                else { Helper.ShowMessage("Şifreler aynı değil.", false); }
            }
            else { Helper.ShowMessage("Boş alanları doldurun.", false); }
        }

        private void enterPictureBox3_Click(object sender, EventArgs e)
        {
            //email verisi verilmişse işlem zinciri başlar
            if (emailTextBox.Text != "")
            {
                //email metninin içinde '@' karakteri olup olmadığını kontrol eder.
                if (emailTextBox.Text.Contains('@'))
                {
                    EmployeeService employeeService = new EmployeeService();

                    if (employeeService.CheckEmailAvailability(emailTextBox.Text))
                    {
                        if (employeeService.ChangeEmail(Employee.Id, emailTextBox.Text))
                        {
                            Helper.ShowMessage("Email başarıyla değiştirildi.", true);
                        }
                    }
                    else { Helper.ShowMessage("Email zaten kullanılıyor", false); }
                }
                else { Helper.ShowMessage("Geçersiz email.", false); }
            }

            //telefon numarası verisi verilmişse işlem zinciri başlar
            if (phoneNumberTextBox.Text != "")
            {
                EmployeeService employeeService = new EmployeeService();

                if (employeeService.CheckPhoneNumberAvailability(phoneNumberTextBox.Text))
                {
                    if (employeeService.ChangePhoneNumber(Employee.Id, phoneNumberTextBox.Text))
                    {
                        Helper.ShowMessage("Telefon numarası başarıyla değiştirildi.", true);
                    }
                }
                else { Helper.ShowMessage("Bu numara zaten kullanılıyor.", false); }
            }
        }

        private void UserProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Pos.UserProfileIsOpen = false;
            ManagementPanel.UserProfileIsOpen = false;
        }

        private void UserProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Helper.OpenPages == 1)
            {

                Application.Exit();
            }
            else { Helper.OpenPages -= 1; }
        }

        private void phoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer basılan tuş rakam değilse ve geri tuşu (Backspace) değilse girişe izin verme
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
