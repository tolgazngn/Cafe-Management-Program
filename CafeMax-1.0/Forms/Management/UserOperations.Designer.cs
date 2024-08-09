namespace CafeMax.Forms.Management
{
    partial class UserOperations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserOperations));
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            usersDataGridView = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            RegistrationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel2 = new System.Windows.Forms.Panel();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            passwordTextBox = new System.Windows.Forms.TextBox();
            newUsernameTextBox = new System.Windows.Forms.TextBox();
            label17 = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            label18 = new System.Windows.Forms.Label();
            fullNameTextBox = new System.Windows.Forms.TextBox();
            employeeIdTextBox = new System.Windows.Forms.TextBox();
            deleteEmployeePanel = new System.Windows.Forms.Panel();
            fullNameTextBox2 = new System.Windows.Forms.TextBox();
            employeeIdTextBox2 = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            deletePictureBox = new System.Windows.Forms.PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usersDataGridView).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            deleteEmployeePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)deletePictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(usersDataGridView);
            panel1.Location = new System.Drawing.Point(92, 106);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(512, 552);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(168, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(163, 38);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcılar";
            // 
            // usersDataGridView
            // 
            usersDataGridView.AllowUserToAddRows = false;
            usersDataGridView.AllowUserToDeleteRows = false;
            usersDataGridView.AllowUserToOrderColumns = true;
            usersDataGridView.AllowUserToResizeColumns = false;
            usersDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(204, 204, 204);
            usersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            usersDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(86, 161, 191);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(250, 250, 250);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            usersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, Username, RegistrationDate });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(104, 166, 250);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            usersDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            usersDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            usersDataGridView.EnableHeadersVisualStyles = false;
            usersDataGridView.Location = new System.Drawing.Point(0, 60);
            usersDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            usersDataGridView.Name = "usersDataGridView";
            usersDataGridView.ReadOnly = true;
            usersDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            usersDataGridView.RowHeadersWidth = 51;
            usersDataGridView.RowTemplate.Height = 24;
            usersDataGridView.Size = new System.Drawing.Size(512, 492);
            usersDataGridView.TabIndex = 0;
            // 
            // Id
            // 
            Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 55;
            // 
            // Username
            // 
            Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            Username.HeaderText = "Kullanıcı Adı";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            Username.ReadOnly = true;
            Username.Width = 200;
            // 
            // RegistrationDate
            // 
            RegistrationDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            RegistrationDate.HeaderText = "Kayıt Tarihi";
            RegistrationDate.MinimumWidth = 6;
            RegistrationDate.Name = "RegistrationDate";
            RegistrationDate.ReadOnly = true;
            RegistrationDate.Width = 300;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(passwordTextBox);
            panel2.Controls.Add(newUsernameTextBox);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(fullNameTextBox);
            panel2.Controls.Add(employeeIdTextBox);
            panel2.Location = new System.Drawing.Point(679, 106);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(348, 372);
            panel2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(88, 235);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(48, 23);
            label4.TabIndex = 33;
            label4.Text = "Şifre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(28, 181);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(111, 23);
            label3.TabIndex = 33;
            label3.Text = "Kullanıcı Adı";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            passwordTextBox.Location = new System.Drawing.Point(147, 232);
            passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new System.Drawing.Size(161, 30);
            passwordTextBox.TabIndex = 34;
            // 
            // newUsernameTextBox
            // 
            newUsernameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            newUsernameTextBox.Location = new System.Drawing.Point(147, 178);
            newUsernameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            newUsernameTextBox.Name = "newUsernameTextBox";
            newUsernameTextBox.Size = new System.Drawing.Size(161, 30);
            newUsernameTextBox.TabIndex = 34;
            newUsernameTextBox.KeyPress += newUsernameTextBox_KeyPress;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label17.ForeColor = System.Drawing.Color.White;
            label17.Location = new System.Drawing.Point(88, 9);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(158, 31);
            label17.TabIndex = 1;
            label17.Text = "Kullanıcı Ekle";
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            pictureBox2.Location = new System.Drawing.Point(147, 291);
            pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(60, 60);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label18.ForeColor = System.Drawing.Color.White;
            label18.Location = new System.Drawing.Point(40, 63);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(99, 23);
            label18.TabIndex = 28;
            label18.Text = "Personel ID";
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Enabled = false;
            fullNameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            fullNameTextBox.Location = new System.Drawing.Point(46, 125);
            fullNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.ReadOnly = true;
            fullNameTextBox.Size = new System.Drawing.Size(262, 30);
            fullNameTextBox.TabIndex = 29;
            // 
            // employeeIdTextBox
            // 
            employeeIdTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            employeeIdTextBox.Location = new System.Drawing.Point(147, 60);
            employeeIdTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            employeeIdTextBox.Name = "employeeIdTextBox";
            employeeIdTextBox.Size = new System.Drawing.Size(161, 30);
            employeeIdTextBox.TabIndex = 29;
            employeeIdTextBox.TextChanged += employeeIdTextBox_TextChanged;
            employeeIdTextBox.KeyPress += employeeIdTextBox_KeyPress;
            // 
            // deleteEmployeePanel
            // 
            deleteEmployeePanel.BackColor = System.Drawing.Color.FromArgb(255, 51, 51);
            deleteEmployeePanel.Controls.Add(fullNameTextBox2);
            deleteEmployeePanel.Controls.Add(employeeIdTextBox2);
            deleteEmployeePanel.Controls.Add(label5);
            deleteEmployeePanel.Controls.Add(label2);
            deleteEmployeePanel.Controls.Add(deletePictureBox);
            deleteEmployeePanel.Location = new System.Drawing.Point(1060, 106);
            deleteEmployeePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            deleteEmployeePanel.Name = "deleteEmployeePanel";
            deleteEmployeePanel.Size = new System.Drawing.Size(348, 372);
            deleteEmployeePanel.TabIndex = 5;
            // 
            // fullNameTextBox2
            // 
            fullNameTextBox2.Enabled = false;
            fullNameTextBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            fullNameTextBox2.Location = new System.Drawing.Point(47, 174);
            fullNameTextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            fullNameTextBox2.Name = "fullNameTextBox2";
            fullNameTextBox2.ReadOnly = true;
            fullNameTextBox2.Size = new System.Drawing.Size(262, 30);
            fullNameTextBox2.TabIndex = 36;
            // 
            // employeeIdTextBox2
            // 
            employeeIdTextBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            employeeIdTextBox2.Location = new System.Drawing.Point(148, 122);
            employeeIdTextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            employeeIdTextBox2.Name = "employeeIdTextBox2";
            employeeIdTextBox2.Size = new System.Drawing.Size(161, 30);
            employeeIdTextBox2.TabIndex = 35;
            employeeIdTextBox2.TextChanged += employeeIdTextBox2_TextChanged;
            employeeIdTextBox2.KeyPress += employeeIdTextBox2_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(39, 125);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(99, 23);
            label5.TabIndex = 33;
            label5.Text = "Personel ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(110, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(141, 31);
            label2.TabIndex = 1;
            label2.Text = "Kullanıcı Sil";
            // 
            // deletePictureBox
            // 
            deletePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            deletePictureBox.Image = (System.Drawing.Image)resources.GetObject("deletePictureBox.Image");
            deletePictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            deletePictureBox.Location = new System.Drawing.Point(148, 291);
            deletePictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            deletePictureBox.Name = "deletePictureBox";
            deletePictureBox.Size = new System.Drawing.Size(60, 60);
            deletePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            deletePictureBox.TabIndex = 32;
            deletePictureBox.TabStop = false;
            deletePictureBox.Click += deletePictureBox_Click;
            // 
            // UserOperations
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(5, 41, 64);
            ClientSize = new System.Drawing.Size(1656, 1055);
            Controls.Add(deleteEmployeePanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "UserOperations";
            Text = "PaymentActivities";
            Load += UserOperations_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usersDataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            deleteEmployeePanel.ResumeLayout(false);
            deleteEmployeePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)deletePictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Panel deleteEmployeePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox deletePictureBox;
        private System.Windows.Forms.TextBox employeeIdTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newUsernameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fullNameTextBox2;
        private System.Windows.Forms.TextBox employeeIdTextBox2;
    }
}