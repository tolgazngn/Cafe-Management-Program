namespace CafeMax.Forms.Management
{
    partial class EmployeeInfos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeInfos));
            employeePanel = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            employeeDataGridView = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DateOfEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DateOfExit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            searchButton = new System.Windows.Forms.PictureBox();
            searchTextBox = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            allRowsCheckBox = new System.Windows.Forms.CheckBox();
            employeePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchButton).BeginInit();
            SuspendLayout();
            // 
            // employeePanel
            // 
            employeePanel.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            employeePanel.Controls.Add(label1);
            employeePanel.Controls.Add(employeeDataGridView);
            employeePanel.Location = new System.Drawing.Point(31, 186);
            employeePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            employeePanel.Name = "employeePanel";
            employeePanel.Size = new System.Drawing.Size(1594, 552);
            employeePanel.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(702, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(128, 38);
            label1.TabIndex = 1;
            label1.Text = "Personel";
            // 
            // employeeDataGridView
            // 
            employeeDataGridView.AllowUserToAddRows = false;
            employeeDataGridView.AllowUserToDeleteRows = false;
            employeeDataGridView.AllowUserToOrderColumns = true;
            employeeDataGridView.AllowUserToResizeColumns = false;
            employeeDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(204, 204, 204);
            employeeDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            employeeDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(86, 161, 191);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(250, 250, 250);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            employeeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, FirstName, Surname, PhoneNumber, Email, Address, DateOfEntry, DateOfExit, IsActive });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(104, 166, 250);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            employeeDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            employeeDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            employeeDataGridView.EnableHeadersVisualStyles = false;
            employeeDataGridView.Location = new System.Drawing.Point(0, 60);
            employeeDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            employeeDataGridView.Name = "employeeDataGridView";
            employeeDataGridView.ReadOnly = true;
            employeeDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            employeeDataGridView.RowHeadersWidth = 51;
            employeeDataGridView.RowTemplate.Height = 24;
            employeeDataGridView.Size = new System.Drawing.Size(1594, 492);
            employeeDataGridView.TabIndex = 0;
            employeeDataGridView.CellContentClick += employeeDataGridView_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 125;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "Ad";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            FirstName.Width = 150;
            // 
            // Surname
            // 
            Surname.HeaderText = "Soyad";
            Surname.MinimumWidth = 6;
            Surname.Name = "Surname";
            Surname.ReadOnly = true;
            Surname.Width = 150;
            // 
            // PhoneNumber
            // 
            PhoneNumber.HeaderText = "Telefon";
            PhoneNumber.MinimumWidth = 6;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.ReadOnly = true;
            PhoneNumber.Width = 125;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 200;
            // 
            // Address
            // 
            Address.HeaderText = "Adres";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.ReadOnly = true;
            Address.Width = 300;
            // 
            // DateOfEntry
            // 
            DateOfEntry.HeaderText = "Giriş Tarihi";
            DateOfEntry.MinimumWidth = 6;
            DateOfEntry.Name = "DateOfEntry";
            DateOfEntry.ReadOnly = true;
            DateOfEntry.Width = 200;
            // 
            // DateOfExit
            // 
            DateOfExit.HeaderText = "Çıkış Tarihi";
            DateOfExit.MinimumWidth = 6;
            DateOfExit.Name = "DateOfExit";
            DateOfExit.ReadOnly = true;
            DateOfExit.Width = 200;
            // 
            // IsActive
            // 
            IsActive.HeaderText = "Durum";
            IsActive.MinimumWidth = 6;
            IsActive.Name = "IsActive";
            IsActive.ReadOnly = true;
            IsActive.Width = 125;
            // 
            // searchButton
            // 
            searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            searchButton.Image = (System.Drawing.Image)resources.GetObject("searchButton.Image");
            searchButton.Location = new System.Drawing.Point(487, 121);
            searchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            searchButton.Name = "searchButton";
            searchButton.Size = new System.Drawing.Size(35, 44);
            searchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            searchButton.TabIndex = 28;
            searchButton.TabStop = false;
            searchButton.Click += searchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            searchTextBox.Location = new System.Drawing.Point(76, 135);
            searchTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new System.Drawing.Size(243, 30);
            searchTextBox.TabIndex = 27;
            searchTextBox.KeyPress += searchTextBox_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(27, 139);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(43, 23);
            label6.TabIndex = 26;
            label6.Text = "İsim";
            // 
            // allRowsCheckBox
            // 
            allRowsCheckBox.AutoSize = true;
            allRowsCheckBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            allRowsCheckBox.ForeColor = System.Drawing.Color.White;
            allRowsCheckBox.Location = new System.Drawing.Point(347, 135);
            allRowsCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            allRowsCheckBox.Name = "allRowsCheckBox";
            allRowsCheckBox.Size = new System.Drawing.Size(134, 27);
            allRowsCheckBox.TabIndex = 29;
            allRowsCheckBox.Text = "Tüm Kayıtlar";
            allRowsCheckBox.UseVisualStyleBackColor = true;
            // 
            // EmployeeInfos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(5, 41, 64);
            ClientSize = new System.Drawing.Size(1656, 1055);
            Controls.Add(allRowsCheckBox);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Controls.Add(label6);
            Controls.Add(employeePanel);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "EmployeeInfos";
            Text = "EmployeeInfos";
            Load += EmployeeInfos_Load;
            employeePanel.ResumeLayout(false);
            employeePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employeeDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel employeePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.PictureBox searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox allRowsCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActive;
    }
}