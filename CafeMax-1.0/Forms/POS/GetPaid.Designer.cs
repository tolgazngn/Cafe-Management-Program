namespace CafeMax
{
    partial class GetPaid
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetPaid));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            getPaidPanel = new System.Windows.Forms.Panel();
            receivedPaymentsDataGridView = new System.Windows.Forms.DataGridView();
            Paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            allPaymentCheckBox = new System.Windows.Forms.CheckBox();
            totalTextBox = new System.Windows.Forms.TextBox();
            remainderTextBox = new System.Windows.Forms.TextBox();
            paidTextBox = new System.Windows.Forms.TextBox();
            paymentTotalTextBox = new System.Windows.Forms.TextBox();
            orderDetailsDataGridView = new System.Windows.Forms.DataGridView();
            TableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            enter = new System.Windows.Forms.PictureBox();
            paymentTypeComboBox = new System.Windows.Forms.ComboBox();
            tableComboBox = new System.Windows.Forms.ComboBox();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            discountTextBox = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            getPaidPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)receivedPaymentsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enter).BeginInit();
            SuspendLayout();
            // 
            // getPaidPanel
            // 
            getPaidPanel.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            getPaidPanel.Controls.Add(discountTextBox);
            getPaidPanel.Controls.Add(label4);
            getPaidPanel.Controls.Add(receivedPaymentsDataGridView);
            getPaidPanel.Controls.Add(pictureBox2);
            getPaidPanel.Controls.Add(allPaymentCheckBox);
            getPaidPanel.Controls.Add(totalTextBox);
            getPaidPanel.Controls.Add(remainderTextBox);
            getPaidPanel.Controls.Add(paidTextBox);
            getPaidPanel.Controls.Add(paymentTotalTextBox);
            getPaidPanel.Controls.Add(orderDetailsDataGridView);
            getPaidPanel.Controls.Add(enter);
            getPaidPanel.Controls.Add(paymentTypeComboBox);
            getPaidPanel.Controls.Add(tableComboBox);
            getPaidPanel.Controls.Add(label9);
            getPaidPanel.Controls.Add(label8);
            getPaidPanel.Controls.Add(label7);
            getPaidPanel.Controls.Add(label5);
            getPaidPanel.Controls.Add(label1);
            getPaidPanel.Controls.Add(label3);
            getPaidPanel.Controls.Add(label10);
            getPaidPanel.Controls.Add(label6);
            getPaidPanel.Controls.Add(label2);
            getPaidPanel.Location = new System.Drawing.Point(62, 83);
            getPaidPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            getPaidPanel.Name = "getPaidPanel";
            getPaidPanel.Size = new System.Drawing.Size(1582, 672);
            getPaidPanel.TabIndex = 4;
            getPaidPanel.Paint += getPaidPanel_Paint;
            // 
            // receivedPaymentsDataGridView
            // 
            receivedPaymentsDataGridView.AllowUserToAddRows = false;
            receivedPaymentsDataGridView.AllowUserToDeleteRows = false;
            receivedPaymentsDataGridView.AllowUserToOrderColumns = true;
            receivedPaymentsDataGridView.AllowUserToResizeColumns = false;
            receivedPaymentsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(204, 204, 204);
            receivedPaymentsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            receivedPaymentsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(86, 161, 191);
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(250, 250, 250);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            receivedPaymentsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            receivedPaymentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            receivedPaymentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Paid, PaymentDate });
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(104, 166, 250);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            receivedPaymentsDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            receivedPaymentsDataGridView.EnableHeadersVisualStyles = false;
            receivedPaymentsDataGridView.Location = new System.Drawing.Point(1261, 125);
            receivedPaymentsDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            receivedPaymentsDataGridView.Name = "receivedPaymentsDataGridView";
            receivedPaymentsDataGridView.ReadOnly = true;
            receivedPaymentsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            receivedPaymentsDataGridView.RowHeadersWidth = 51;
            receivedPaymentsDataGridView.RowTemplate.Height = 24;
            receivedPaymentsDataGridView.Size = new System.Drawing.Size(296, 515);
            receivedPaymentsDataGridView.TabIndex = 11;
            // 
            // Paid
            // 
            Paid.HeaderText = "Ödenen";
            Paid.MinimumWidth = 6;
            Paid.Name = "Paid";
            Paid.ReadOnly = true;
            Paid.Width = 125;
            // 
            // PaymentDate
            // 
            PaymentDate.HeaderText = "Tarih";
            PaymentDate.MinimumWidth = 6;
            PaymentDate.Name = "PaymentDate";
            PaymentDate.ReadOnly = true;
            PaymentDate.Width = 125;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(22, 19);
            pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(110, 120);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // allPaymentCheckBox
            // 
            allPaymentCheckBox.AutoSize = true;
            allPaymentCheckBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            allPaymentCheckBox.ForeColor = System.Drawing.Color.White;
            allPaymentCheckBox.Location = new System.Drawing.Point(376, 314);
            allPaymentCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            allPaymentCheckBox.Name = "allPaymentCheckBox";
            allPaymentCheckBox.Size = new System.Drawing.Size(121, 27);
            allPaymentCheckBox.TabIndex = 6;
            allPaymentCheckBox.Text = "Tüm Hesap";
            allPaymentCheckBox.UseVisualStyleBackColor = true;
            allPaymentCheckBox.CheckedChanged += allPaymentCheckBox_CheckedChanged;
            // 
            // totalTextBox
            // 
            totalTextBox.Enabled = false;
            totalTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            totalTextBox.Location = new System.Drawing.Point(235, 610);
            totalTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            totalTextBox.Name = "totalTextBox";
            totalTextBox.ReadOnly = true;
            totalTextBox.Size = new System.Drawing.Size(96, 30);
            totalTextBox.TabIndex = 5;
            totalTextBox.TextChanged += textBox4_TextChanged;
            // 
            // remainderTextBox
            // 
            remainderTextBox.Enabled = false;
            remainderTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            remainderTextBox.Location = new System.Drawing.Point(235, 561);
            remainderTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            remainderTextBox.Name = "remainderTextBox";
            remainderTextBox.ReadOnly = true;
            remainderTextBox.Size = new System.Drawing.Size(96, 30);
            remainderTextBox.TabIndex = 5;
            // 
            // paidTextBox
            // 
            paidTextBox.Enabled = false;
            paidTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            paidTextBox.Location = new System.Drawing.Point(235, 466);
            paidTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            paidTextBox.Name = "paidTextBox";
            paidTextBox.ReadOnly = true;
            paidTextBox.Size = new System.Drawing.Size(96, 30);
            paidTextBox.TabIndex = 5;
            // 
            // paymentTotalTextBox
            // 
            paymentTotalTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            paymentTotalTextBox.Location = new System.Drawing.Point(215, 311);
            paymentTotalTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            paymentTotalTextBox.MaxLength = 7;
            paymentTotalTextBox.Name = "paymentTotalTextBox";
            paymentTotalTextBox.Size = new System.Drawing.Size(146, 30);
            paymentTotalTextBox.TabIndex = 5;
            paymentTotalTextBox.TextChanged += paymentTotalTextBox_TextChanged;
            paymentTotalTextBox.KeyPress += paymentTotalTextBox_KeyPress;
            // 
            // orderDetailsDataGridView
            // 
            orderDetailsDataGridView.AllowUserToAddRows = false;
            orderDetailsDataGridView.AllowUserToDeleteRows = false;
            orderDetailsDataGridView.AllowUserToOrderColumns = true;
            orderDetailsDataGridView.AllowUserToResizeColumns = false;
            orderDetailsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(204, 204, 204);
            orderDetailsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            orderDetailsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(86, 161, 191);
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(250, 250, 250);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            orderDetailsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            orderDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { TableName, ProductName, Amount, TotalPrice, Date });
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(104, 166, 250);
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            orderDetailsDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            orderDetailsDataGridView.EnableHeadersVisualStyles = false;
            orderDetailsDataGridView.Location = new System.Drawing.Point(503, 125);
            orderDetailsDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            orderDetailsDataGridView.Name = "orderDetailsDataGridView";
            orderDetailsDataGridView.ReadOnly = true;
            orderDetailsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            orderDetailsDataGridView.RowHeadersWidth = 51;
            orderDetailsDataGridView.RowTemplate.Height = 24;
            orderDetailsDataGridView.Size = new System.Drawing.Size(725, 515);
            orderDetailsDataGridView.TabIndex = 4;
            // 
            // TableName
            // 
            TableName.HeaderText = "Masa Adı";
            TableName.MinimumWidth = 6;
            TableName.Name = "TableName";
            TableName.ReadOnly = true;
            TableName.Width = 125;
            // 
            // ProductName
            // 
            ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            ProductName.HeaderText = "Ürün Adı";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Width = 106;
            // 
            // Amount
            // 
            Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            Amount.HeaderText = "Miktar";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.Width = 200;
            // 
            // TotalPrice
            // 
            TotalPrice.HeaderText = "Toplam Fiyat";
            TotalPrice.MinimumWidth = 6;
            TotalPrice.Name = "TotalPrice";
            TotalPrice.ReadOnly = true;
            TotalPrice.Width = 125;
            // 
            // Date
            // 
            Date.HeaderText = "Tarih";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 125;
            // 
            // enter
            // 
            enter.Cursor = System.Windows.Forms.Cursors.Hand;
            enter.Image = (System.Drawing.Image)resources.GetObject("enter.Image");
            enter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            enter.Location = new System.Drawing.Point(255, 366);
            enter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            enter.Name = "enter";
            enter.Size = new System.Drawing.Size(60, 60);
            enter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            enter.TabIndex = 4;
            enter.TabStop = false;
            enter.Click += enter_Click;
            // 
            // paymentTypeComboBox
            // 
            paymentTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            paymentTypeComboBox.FormattingEnabled = true;
            paymentTypeComboBox.Location = new System.Drawing.Point(215, 251);
            paymentTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            paymentTypeComboBox.Name = "paymentTypeComboBox";
            paymentTypeComboBox.Size = new System.Drawing.Size(146, 31);
            paymentTypeComboBox.TabIndex = 3;
            // 
            // tableComboBox
            // 
            tableComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tableComboBox.FormattingEnabled = true;
            tableComboBox.Location = new System.Drawing.Point(215, 187);
            tableComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableComboBox.Name = "tableComboBox";
            tableComboBox.Size = new System.Drawing.Size(146, 31);
            tableComboBox.TabIndex = 3;
            tableComboBox.SelectedIndexChanged += tableComboBox_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.Color.White;
            label9.Location = new System.Drawing.Point(160, 617);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(69, 23);
            label9.TabIndex = 1;
            label9.Text = "Toplam";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(170, 564);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(59, 23);
            label8.TabIndex = 1;
            label8.Text = "Kalan ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(157, 469);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(72, 23);
            label7.TabIndex = 1;
            label7.Text = "Ödenen";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(89, 314);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(120, 23);
            label5.TabIndex = 1;
            label5.Text = "Ödeme Tutarı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(71, 251);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(138, 23);
            label1.TabIndex = 1;
            label1.Text = "Ödeme Yöntemi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(158, 191);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(51, 23);
            label3.TabIndex = 1;
            label3.Text = "Masa";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label10.ForeColor = System.Drawing.Color.White;
            label10.Location = new System.Drawing.Point(1313, 90);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(202, 31);
            label10.TabIndex = 1;
            label10.Text = "Yapılan Ödemeler";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(768, 80);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(189, 31);
            label6.TabIndex = 1;
            label6.Text = "Sipariş Detayları";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(536, 19);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(119, 31);
            label2.TabIndex = 1;
            label2.Text = "Ödeme Al";
            // 
            // discountTextBox
            // 
            discountTextBox.Enabled = false;
            discountTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            discountTextBox.Location = new System.Drawing.Point(235, 514);
            discountTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            discountTextBox.Name = "discountTextBox";
            discountTextBox.ReadOnly = true;
            discountTextBox.Size = new System.Drawing.Size(96, 30);
            discountTextBox.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(157, 517);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(69, 23);
            label4.TabIndex = 12;
            label4.Text = "İndirim";
            // 
            // GetPaid
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(5, 41, 64);
            ClientSize = new System.Drawing.Size(1656, 1055);
            Controls.Add(getPaidPanel);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "GetPaid";
            Text = "GetPaid";
            Load += GetPaid_Load;
            getPaidPanel.ResumeLayout(false);
            getPaidPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)receivedPaymentsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)enter).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel getPaidPanel;
        private System.Windows.Forms.CheckBox allPaymentCheckBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox remainderTextBox;
        private System.Windows.Forms.TextBox paidTextBox;
        private System.Windows.Forms.TextBox paymentTotalTextBox;
        private System.Windows.Forms.DataGridView orderDetailsDataGridView;
        private System.Windows.Forms.PictureBox enter;
        private System.Windows.Forms.ComboBox paymentTypeComboBox;
        private System.Windows.Forms.ComboBox tableComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridView receivedPaymentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.Label label4;
    }
}