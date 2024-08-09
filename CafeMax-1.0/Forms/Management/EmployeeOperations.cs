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

namespace CafeMax.Forms.Management
{
    public partial class EmployeeOperations : Form
    {
        EmployeeService EmployeeService;
        public EmployeeOperations()
        {
            InitializeComponent();

            EmployeeService = new EmployeeService();
        }

        private void addPictureBox_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && surnameTextBox.Text != "" && jobComboBox.Text != "")
            {
                //email varsa kontrolü
                if (emailTextBox.Text != "")
                {
                    if (!EmailControl()) { return; }
                }

                //phone number varsa kontrolü
                if (phoneTextBox.Text != "")
                {
                    if (!PhoneNumberControl()) { return; }
                }

                //nesnelerdeki verileri employee nesnesine atama
                Employee employee = new Employee();

                employee.Name = nameTextBox.Text;
                employee.Surname = surnameTextBox.Text;

                if (phoneTextBox.Text != "") { employee.PhoneNumber = phoneTextBox.Text; }

                if (emailTextBox.Text != "") { employee.Email = emailTextBox.Text; }

                if (addressRichTextBox.Text != "") { employee.Address = addressRichTextBox.Text; }

                employee.Job = jobComboBox.Text;

                if (salaryTextBox.Text != "") { employee.Salary = Convert.ToDecimal(salaryTextBox.Text); }

                //onay 
                DialogResult result = Helper.ShowMessage("İşlemi onaylıyor musunuz?");
                if (result == DialogResult.Yes)
                {
                    EmployeeService employeeService = new EmployeeService();

                    if (employeeService.AddEmployee(employee))
                    {
                        Helper.ShowMessage($"Yeni personel eklendi.", true);

                        ClearAddPanel();
                    }
                    else { Helper.ShowMessage("İşlem başarısız.", false); }
                }
                else if (result == DialogResult.No) { Helper.ShowMessage("İşlem iptal edildi.", true); }
                else { Helper.ShowMessage("İşlem iptal edildi.", true); }
            }
            else { Helper.ShowMessage("Zorunlu alanları doldurun.", false); }

        }


        private void ClearAddPanel()
        {
            nameTextBox.Clear();
            surnameTextBox.Clear();
            phoneTextBox.Clear();
            emailTextBox.Clear();
            addressRichTextBox.Clear();
            jobComboBox.Text = "";
            salaryTextBox.Text = "";
        }

        private void EmployeeOperations_Load(object sender, EventArgs e)
        {
            JobService jobService = new JobService();

            List<Job> jobs = jobService.GetAll();

            foreach (Job job in jobs)
            {
                jobComboBox.Items.Add(job.Title);
                newJobComboBox.Items.Add(job.Title);
            }
        }

        private bool EmailControl()
        {
            if (emailTextBox.Text.Contains('@'))
            {
                EmployeeService employeeService = new EmployeeService();

                if (employeeService.CheckEmailAvailability(emailTextBox.Text))
                {
                    return true;
                }
                else { Helper.ShowMessage("Email zaten kullanılıyor", false); return false; }
            }
            else { Helper.ShowMessage("Geçersiz email.", false); return false; }
        }

        private bool PhoneNumberControl()
        {
            EmployeeService employeeService = new EmployeeService();

            if (employeeService.CheckPhoneNumberAvailability(phoneTextBox.Text))
            {
                return true;
            }
            else { Helper.ShowMessage("Bu numara zaten kullanılıyor.", false); return false; }
        }

        private void employeeIdTextBox_TextChanged(object sender, EventArgs e)
        {
            if (employeeIdTextBox.Text != "")
            {
                GetFullNameById(Convert.ToInt32(employeeIdTextBox.Text), fullNameTextBox);
            }
            else { fullNameTextBox.Clear(); }

        }

        private void employeeIdTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (employeeIdTextBox2.Text != "")
            {
                GetFullNameById(Convert.ToInt32(employeeIdTextBox2.Text), fullNameTextBox2);
            }
            else { fullNameTextBox2.Clear(); }
        }

        private void employeeIdTextBox3_TextChanged(object sender, EventArgs e)
        {
            if (employeeIdTextBox3.Text != "")
            {
                GetFullNameById(Convert.ToInt32(employeeIdTextBox3.Text), fullNameTextBox3);
            }
            else { fullNameTextBox3.Clear(); }
        }

        private void employeeIdTextBox4_TextChanged(object sender, EventArgs e)
        {
            if (employeeIdTextBox4.Text != "")
            {
                GetFullNameById(Convert.ToInt32(employeeIdTextBox4.Text), fullNameTextBox4);
                GetJobById(Convert.ToInt32(employeeIdTextBox4.Text));
            }
            else { fullNameTextBox4.Clear(); jobTextBox.Clear(); }
        }

        private void GetFullNameById(int id, TextBox fullnameTextBox)
        {
            EmployeeService employeeService = new EmployeeService();

            fullnameTextBox.Text = employeeService.GetFullNameById(id);
        }

        private void GetJobById(int id)
        {
            EmployeeService employeeService = new EmployeeService();

            jobTextBox.Text = employeeService.GetJobById(id);
        }

        private void deletePictureBox_Click(object sender, EventArgs e)
        {
            if (employeeIdTextBox.Text != "")
            {
                if (fullNameTextBox.Text != "")
                {
                    EmployeeService employeeService = new EmployeeService();

                    //onay
                    DialogResult result = Helper.ShowMessage("İşlemi onaylıyor musunuz?");
                    if (result == DialogResult.Yes)
                    {
                        if (allRowsCheckBox.Checked)
                        {
                            if (employeeService.DeleteEmployee(Convert.ToInt32(employeeIdTextBox.Text)))
                            {
                                Helper.ShowMessage("Personelin tüm kayıtları silindi.", true);
                            }
                            else { Helper.ShowMessage("İşlem başarısız.", true); }
                        }
                        else
                        {
                            if (employeeService.ChangeActivityById(Convert.ToInt32(employeeIdTextBox.Text), false))
                            {
                                Helper.ShowMessage("Personel çıkarıldı.", true);
                                employeeIdTextBox.Clear();
                                fullNameTextBox.Clear();
                            }
                            else { Helper.ShowMessage("İşlem başarısız.", true); }
                        }
                    }
                    else if (result == DialogResult.No) { Helper.ShowMessage("İşlem iptal edildi.", true); }
                    else { Helper.ShowMessage("İşlem iptal edildi.", true); }
                }
                else { Helper.ShowMessage("Verilen id ile eşleşen kişi bulunamadı.", false); }
            }
            else { Helper.ShowMessage("Id giriniz.", false); }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (employeeIdTextBox2.Text != "")
            {
                if (fullNameTextBox2.Text != "")
                {
                    EmployeeService employeeService = new EmployeeService();

                    //onay
                    DialogResult result = Helper.ShowMessage("İşlemi onaylıyor musunuz?");
                    if (result == DialogResult.Yes)
                    {
                        if (employeeService.ChangeActivityById(Convert.ToInt32(employeeIdTextBox2.Text), true))
                        {
                            Helper.ShowMessage($"{fullNameTextBox2.Text} artık aktif.", true);
                            employeeIdTextBox2.Clear();
                            fullNameTextBox2.Clear();
                        }
                    }
                    else if (result == DialogResult.No) { Helper.ShowMessage("İşlem iptal edildi.", true); }
                    else { Helper.ShowMessage("İşlem iptal edildi.", true); }
                }
                else { Helper.ShowMessage("Verilen id ile eşleşen kişi bulunamadı.", false); }
            }
            else { Helper.ShowMessage("Id giriniz.", false); }
        }

        private void updatePhoneNumberPictureBox_Click(object sender, EventArgs e)
        {
            if (employeeIdTextBox3.Text != "")
            {
                if (fullNameTextBox3.Text != "")
                {
                    if (numberTextBox.Text != "")
                    {
                        if (PhoneNumberControl())
                        {
                            EmployeeService employeeService = new EmployeeService();

                            //onay
                            DialogResult result = Helper.ShowMessage("İşlemi onaylıyor musunuz?");
                            if (result == DialogResult.Yes)
                            {
                                if (employeeService.ChangePhoneNumber(Convert.ToInt32(employeeIdTextBox3.Text), numberTextBox.Text))
                                {
                                    Helper.ShowMessage("Numara güncellendi.", true);
                                    employeeIdTextBox3.Clear();
                                    fullNameTextBox3.Clear();
                                    numberTextBox.Clear();
                                }
                                else { Helper.ShowMessage("İşlem başarısız.", false); }
                            }
                            else if (result == DialogResult.No) { Helper.ShowMessage("İşlem iptal edildi.", true); }
                            else { Helper.ShowMessage("İşlem iptal edildi.", true); }
                        }
                    }
                    else { Helper.ShowMessage("Telefon numarası giriniz.", false); }
                }
                else { Helper.ShowMessage("Verilen id ile eşleşen kişi bulunamadı.", false); }
            }
            else { Helper.ShowMessage("Id giriniz.", false); }
        }


        private void updateJobPictureBox_Click(object sender, EventArgs e)
        {
            if (employeeIdTextBox4.Text != "")
            {
                if (fullNameTextBox4.Text != "")
                {
                    if (newJobComboBox.Text != "")
                    {
                        //onay
                        DialogResult result = Helper.ShowMessage("İşlemi onaylıyor musunuz?");
                        if (result == DialogResult.Yes)
                        {
                            EmployeeService employeeService = new EmployeeService();

                            if (employeeService.ChangeJobById(Convert.ToInt32(employeeIdTextBox4.Text), newJobComboBox.Text))
                            {
                                Helper.ShowMessage($"{fullNameTextBox4.Text} artık bir {newJobComboBox.Text.ToLower()}.", true);
                                employeeIdTextBox4.Clear();
                                fullNameTextBox4.Clear();
                                jobTextBox.Clear();
                            }
                            else { Helper.ShowMessage("İşlem başarısız.", false); }
                        }
                        else if (result == DialogResult.No) { Helper.ShowMessage("İşlem iptal edildi.", true); }
                        else { Helper.ShowMessage("İşlem iptal edildi.", true); }
                    }
                    else { Helper.ShowMessage("Görev seçiniz.", false); }
                }
                else { Helper.ShowMessage("Verilen id ile eşleşen kişi bulunamadı.", false); }
            }
            else { Helper.ShowMessage("Id giriniz.", false); }
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer basılan tuş harf değilse ve geri tuşu (Backspace) değilse girişe izin verme
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void surnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer basılan tuş harf değilse ve geri tuşu (Backspace) değilse girişe izin verme
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer basılan tuş rakam değilse ve geri tuşu (Backspace) değilse girişe izin verme
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void salaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer basılan tuş rakam değilse ve geri tuşu (Backspace) değilse girişe izin verme
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void employeeIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer basılan tuş rakam değilse ve geri tuşu (Backspace) değilse girişe izin verme
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void employeeIdTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer basılan tuş rakam değilse ve geri tuşu (Backspace) değilse girişe izin verme
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void numberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer basılan tuş rakam değilse ve geri tuşu (Backspace) değilse girişe izin verme
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
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

        private void employeeIdTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer basılan tuş rakam değilse ve geri tuşu (Backspace) değilse girişe izin verme
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
