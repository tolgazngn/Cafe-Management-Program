namespace CafeMax.Forms.Management
{
    partial class AddExpense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddExpense));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            addExpensePanel = new System.Windows.Forms.Panel();
            amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            enterPictureBox = new System.Windows.Forms.PictureBox();
            descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            paymentTypeComboBox = new System.Windows.Forms.ComboBox();
            paidTextBox = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label = new System.Windows.Forms.Label();
            typeTextBox = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            salesLogsPanel = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            expensesDataGridView = new System.Windows.Forms.DataGridView();
            Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            addExpensePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)amountNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enterPictureBox).BeginInit();
            salesLogsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)expensesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // addExpensePanel
            // 
            addExpensePanel.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            addExpensePanel.Controls.Add(amountNumericUpDown);
            addExpensePanel.Controls.Add(pictureBox1);
            addExpensePanel.Controls.Add(enterPictureBox);
            addExpensePanel.Controls.Add(descriptionRichTextBox);
            addExpensePanel.Controls.Add(paymentTypeComboBox);
            addExpensePanel.Controls.Add(paidTextBox);
            addExpensePanel.Controls.Add(label3);
            addExpensePanel.Controls.Add(label8);
            addExpensePanel.Controls.Add(label7);
            addExpensePanel.Controls.Add(label);
            addExpensePanel.Controls.Add(typeTextBox);
            addExpensePanel.Controls.Add(label6);
            addExpensePanel.Controls.Add(label1);
            addExpensePanel.Location = new System.Drawing.Point(24, 139);
            addExpensePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            addExpensePanel.Name = "addExpensePanel";
            addExpensePanel.Size = new System.Drawing.Size(554, 608);
            addExpensePanel.TabIndex = 4;
            // 
            // amountNumericUpDown
            // 
            amountNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            amountNumericUpDown.Location = new System.Drawing.Point(133, 152);
            amountNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            amountNumericUpDown.Name = "amountNumericUpDown";
            amountNumericUpDown.Size = new System.Drawing.Size(146, 30);
            amountNumericUpDown.TabIndex = 33;
            amountNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            pictureBox1.Location = new System.Drawing.Point(380, 22);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(140, 150);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // enterPictureBox
            // 
            enterPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            enterPictureBox.Image = (System.Drawing.Image)resources.GetObject("enterPictureBox.Image");
            enterPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            enterPictureBox.Location = new System.Drawing.Point(219, 489);
            enterPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            enterPictureBox.Name = "enterPictureBox";
            enterPictureBox.Size = new System.Drawing.Size(60, 60);
            enterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            enterPictureBox.TabIndex = 32;
            enterPictureBox.TabStop = false;
            enterPictureBox.Click += enterPictureBox_Click;
            // 
            // descriptionRichTextBox
            // 
            descriptionRichTextBox.Location = new System.Drawing.Point(133, 215);
            descriptionRichTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            descriptionRichTextBox.MaxLength = 250;
            descriptionRichTextBox.Name = "descriptionRichTextBox";
            descriptionRichTextBox.Size = new System.Drawing.Size(243, 119);
            descriptionRichTextBox.TabIndex = 31;
            descriptionRichTextBox.Text = "";
            // 
            // paymentTypeComboBox
            // 
            paymentTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            paymentTypeComboBox.FormattingEnabled = true;
            paymentTypeComboBox.Location = new System.Drawing.Point(133, 419);
            paymentTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            paymentTypeComboBox.Name = "paymentTypeComboBox";
            paymentTypeComboBox.Size = new System.Drawing.Size(161, 31);
            paymentTypeComboBox.TabIndex = 30;
            // 
            // paidTextBox
            // 
            paidTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            paidTextBox.Location = new System.Drawing.Point(133, 360);
            paidTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            paidTextBox.Name = "paidTextBox";
            paidTextBox.Size = new System.Drawing.Size(161, 30);
            paidTextBox.TabIndex = 29;
            paidTextBox.KeyPress += paidTextBox_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(55, 364);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(72, 23);
            label3.TabIndex = 28;
            label3.Text = "Ödenen";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(18, 422);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(109, 23);
            label8.TabIndex = 28;
            label8.Text = "Ödeme Türü";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(43, 212);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(84, 23);
            label7.TabIndex = 28;
            label7.Text = "Açıklama";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label.ForeColor = System.Drawing.Color.White;
            label.Location = new System.Drawing.Point(58, 154);
            label.Name = "label";
            label.Size = new System.Drawing.Size(64, 23);
            label.TabIndex = 28;
            label.Text = "Miktar";
            // 
            // typeTextBox
            // 
            typeTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            typeTextBox.Location = new System.Drawing.Point(133, 84);
            typeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            typeTextBox.Name = "typeTextBox";
            typeTextBox.Size = new System.Drawing.Size(161, 30);
            typeTextBox.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(32, 88);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(95, 23);
            label6.TabIndex = 28;
            label6.Text = "Gider Türü";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(182, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(150, 38);
            label1.TabIndex = 1;
            label1.Text = "Gider Ekle";
            // 
            // salesLogsPanel
            // 
            salesLogsPanel.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            salesLogsPanel.Controls.Add(label2);
            salesLogsPanel.Controls.Add(expensesDataGridView);
            salesLogsPanel.Location = new System.Drawing.Point(584, 139);
            salesLogsPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            salesLogsPanel.Name = "salesLogsPanel";
            salesLogsPanel.Size = new System.Drawing.Size(1067, 608);
            salesLogsPanel.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(432, 12);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(187, 38);
            label2.TabIndex = 1;
            label2.Text = "Tüm Giderler";
            // 
            // expensesDataGridView
            // 
            expensesDataGridView.AllowUserToAddRows = false;
            expensesDataGridView.AllowUserToDeleteRows = false;
            expensesDataGridView.AllowUserToOrderColumns = true;
            expensesDataGridView.AllowUserToResizeColumns = false;
            expensesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(204, 204, 204);
            expensesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            expensesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(86, 161, 191);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(250, 250, 250);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            expensesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            expensesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            expensesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Type, Amount, Description, Paid, PaymentMethod, EmployeeName, Date });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(104, 166, 250);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            expensesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            expensesDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            expensesDataGridView.EnableHeadersVisualStyles = false;
            expensesDataGridView.Location = new System.Drawing.Point(0, 67);
            expensesDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            expensesDataGridView.Name = "expensesDataGridView";
            expensesDataGridView.ReadOnly = true;
            expensesDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            expensesDataGridView.RowHeadersWidth = 51;
            expensesDataGridView.RowTemplate.Height = 24;
            expensesDataGridView.Size = new System.Drawing.Size(1067, 541);
            expensesDataGridView.TabIndex = 0;
            // 
            // Type
            // 
            Type.HeaderText = "Tür";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.ReadOnly = true;
            Type.Width = 125;
            // 
            // Amount
            // 
            Amount.HeaderText = "Miktar";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.Width = 125;
            // 
            // Description
            // 
            Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            Description.HeaderText = "Açıklama";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.Width = 200;
            // 
            // Paid
            // 
            Paid.HeaderText = "Ödenen";
            Paid.MinimumWidth = 6;
            Paid.Name = "Paid";
            Paid.ReadOnly = true;
            Paid.Width = 125;
            // 
            // PaymentMethod
            // 
            PaymentMethod.HeaderText = "Ödeme Türü";
            PaymentMethod.MinimumWidth = 6;
            PaymentMethod.Name = "PaymentMethod";
            PaymentMethod.ReadOnly = true;
            PaymentMethod.Width = 125;
            // 
            // EmployeeName
            // 
            EmployeeName.HeaderText = "Kişi";
            EmployeeName.MinimumWidth = 6;
            EmployeeName.Name = "EmployeeName";
            EmployeeName.ReadOnly = true;
            EmployeeName.Width = 125;
            // 
            // Date
            // 
            Date.HeaderText = "Tarih/Saat";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 200;
            // 
            // AddExpense
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(5, 41, 64);
            ClientSize = new System.Drawing.Size(1656, 1055);
            Controls.Add(salesLogsPanel);
            Controls.Add(addExpensePanel);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "AddExpense";
            Text = "AddExpense";
            Load += AddExpense_Load;
            addExpensePanel.ResumeLayout(false);
            addExpensePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)amountNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)enterPictureBox).EndInit();
            salesLogsPanel.ResumeLayout(false);
            salesLogsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)expensesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel addExpensePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox enterPictureBox;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.ComboBox paymentTypeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
        private System.Windows.Forms.TextBox paidTextBox;
        private System.Windows.Forms.Panel salesLogsPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView expensesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}