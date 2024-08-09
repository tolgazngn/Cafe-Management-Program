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

namespace CafeMax.Forms.Management
{
    public partial class UserOperations : Form
    {
        public UserOperations()
        {
            InitializeComponent();
        }

        private void UserOperations_Load(object sender, EventArgs e)
        {
            GetAllUsers();
        }

        private void GetAllUsers()
        {
            usersDataGridView.Rows.Clear();

            UserService userService = new UserService();

            List<User> users = userService.GetAll();

            foreach (User user in users)
            {
                usersDataGridView.Rows.Add(user.Id, user.Username, user.DateOfRegistration);
            }
        }

        private void employeeIdTextBox_TextChanged(object sender, EventArgs e)
        {
            if (employeeIdTextBox.Text != "")
            {
                GetFullNameById(Convert.ToInt32(employeeIdTextBox.Text), fullNameTextBox);
            }
            else { fullNameTextBox.Clear(); }
        }

        private void GetFullNameById(int id, TextBox fullnameTextBox)
        {
            EmployeeService employeeService = new EmployeeService();

            fullnameTextBox.Text = employeeService.GetFullNameById(id);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (employeeIdTextBox.Text != "" && newUsernameTextBox.Text != "" && passwordTextBox.Text != "")
            {
                UserService userService = new UserService();
                ValidationService validationService = new ValidationService();

                if (validationService.isValidUsername(newUsernameTextBox.Text))
                {
                    if (!userService.CheckUsernameAvailability(newUsernameTextBox.Text))
                    {
                        if (validationService.isValidPassword(passwordTextBox.Text))
                        {
                            //onay
                            DialogResult result = Helper.ShowMessage("İşlemi onaylıyor musunuz?");
                            if (result == DialogResult.Yes)
                            {
                                User user = new User();

                                user.Id = Convert.ToInt32(employeeIdTextBox.Text);
                                user.Username = newUsernameTextBox.Text;
                                user.Password = passwordTextBox.Text;

                                if (userService.AddUser(user))
                                {
                                    Helper.ShowMessage("İşlem başarılı.", true);

                                    employeeIdTextBox.Clear();
                                    fullNameTextBox.Clear();
                                    newUsernameTextBox.Clear();
                                    passwordTextBox.Clear();

                                    GetAllUsers();
                                }
                                else { Helper.ShowMessage("İşlem başarısız.", false); }
                            }
                            else if (result == DialogResult.No) { Helper.ShowMessage("İşlem iptal edildi.", true); }
                            else { Helper.ShowMessage("İşlem iptal edildi.", true); }
                        }
                        else { Helper.ShowMessage("Şifre en az 6, en fazla 20 karakter olmalıdır.", false); }
                    }
                    else { Helper.ShowMessage("Kullanıcı adı kullanılıyor.", false); }
                }
                else { Helper.ShowMessage("Kullanıcı adı en az 3, en fazla 20 karakter olmalıdır.", false); }
            }
            else { Helper.ShowMessage("Boş alan olmamalı.", false); }
        }



        private void deletePictureBox_Click(object sender, EventArgs e)
        {
            if (employeeIdTextBox2.Text != "" && fullNameTextBox2.Text != "")
            {
                if (fullNameTextBox2.Text != ManagementPanel.FullName)
                {
                    //onay
                    DialogResult result = Helper.ShowMessage("İşlemi onaylıyor musunuz?");
                    if (result == DialogResult.Yes)
                    {
                        UserService userService = new UserService();

                        if (userService.DeleteUser(Convert.ToInt32(employeeIdTextBox2.Text)))
                        {
                            Helper.ShowMessage("Kullanıcı silindi.", true);

                            employeeIdTextBox2.Clear();
                            fullNameTextBox2.Clear();

                            GetAllUsers();
                        }
                        else { Helper.ShowMessage("İşlem başarısız.", false); }
                    }
                    else if (result == DialogResult.No) { Helper.ShowMessage("İşlem iptal edildi.", true); }
                    else { Helper.ShowMessage("İşlem iptal edildi.", true); }

                }
                else { Helper.ShowMessage("Kendi hesabınızı silemezsiniz.", true); }
            }
            else { Helper.ShowMessage("Boş alan olmamalı.", false); }
        }

        private void employeeIdTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (employeeIdTextBox2.Text != "")
            {
                GetFullNameById(Convert.ToInt32(employeeIdTextBox2.Text), fullNameTextBox2);
            }
            else { fullNameTextBox2.Clear(); }
        }

        private void employeeIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer basılan tuş rakam değilse ve geri tuşu (Backspace) değilse girişe izin verme
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void newUsernameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer basılan tuş harf değilse ve geri tuşu (Backspace) değilse girişe izin verme
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void employeeIdTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer basılan tuş rakam değilse ve geri tuşu (Backspace) değilse girişe izin verme
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
