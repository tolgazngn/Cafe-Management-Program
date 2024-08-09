namespace CafeMax
{
    partial class Sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            salesPanel = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            salesDataGridView = new System.Windows.Forms.DataGridView();
            SaleCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TotalPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SaleStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            paymentActivitiesPanel = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            paymentActivitiesDataGridView = new System.Windows.Forms.DataGridView();
            PayCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tableComboBox = new System.Windows.Forms.ComboBox();
            searchDetailsPictureBox = new System.Windows.Forms.PictureBox();
            label6 = new System.Windows.Forms.Label();
            updateStockPanel = new System.Windows.Forms.Panel();
            discountTotalTextBox = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            DeleteDiscountButton = new System.Windows.Forms.Button();
            AddDiscountButton = new System.Windows.Forms.Button();
            fullTableComboBox = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            salesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)salesDataGridView).BeginInit();
            paymentActivitiesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)paymentActivitiesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchDetailsPictureBox).BeginInit();
            updateStockPanel.SuspendLayout();
            SuspendLayout();
            // 
            // salesPanel
            // 
            salesPanel.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            salesPanel.Controls.Add(label1);
            salesPanel.Controls.Add(salesDataGridView);
            salesPanel.Location = new System.Drawing.Point(49, 81);
            salesPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            salesPanel.Name = "salesPanel";
            salesPanel.Size = new System.Drawing.Size(980, 552);
            salesPanel.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(420, 14);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(93, 31);
            label1.TabIndex = 1;
            label1.Text = "Satışlar";
            // 
            // salesDataGridView
            // 
            salesDataGridView.AllowUserToAddRows = false;
            salesDataGridView.AllowUserToDeleteRows = false;
            salesDataGridView.AllowUserToOrderColumns = true;
            salesDataGridView.AllowUserToResizeColumns = false;
            salesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(204, 204, 204);
            salesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            salesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(86, 161, 191);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(250, 250, 250);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            salesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            salesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            salesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { SaleCode, TableName, Discount, TotalPrice, TotalPaid, SaleStatus, Date });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(104, 166, 250);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            salesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            salesDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            salesDataGridView.EnableHeadersVisualStyles = false;
            salesDataGridView.Location = new System.Drawing.Point(0, 60);
            salesDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            salesDataGridView.Name = "salesDataGridView";
            salesDataGridView.ReadOnly = true;
            salesDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            salesDataGridView.RowHeadersWidth = 51;
            salesDataGridView.RowTemplate.Height = 24;
            salesDataGridView.Size = new System.Drawing.Size(980, 492);
            salesDataGridView.TabIndex = 0;
            // 
            // SaleCode
            // 
            SaleCode.HeaderText = "Satış Kodu";
            SaleCode.MinimumWidth = 6;
            SaleCode.Name = "SaleCode";
            SaleCode.ReadOnly = true;
            SaleCode.Width = 150;
            // 
            // TableName
            // 
            TableName.HeaderText = "Masa Adı";
            TableName.MinimumWidth = 6;
            TableName.Name = "TableName";
            TableName.ReadOnly = true;
            TableName.Width = 125;
            // 
            // Discount
            // 
            Discount.HeaderText = "İndirim";
            Discount.MinimumWidth = 6;
            Discount.Name = "Discount";
            Discount.ReadOnly = true;
            Discount.Width = 125;
            // 
            // TotalPrice
            // 
            TotalPrice.HeaderText = "Toplam Fiyat";
            TotalPrice.MinimumWidth = 6;
            TotalPrice.Name = "TotalPrice";
            TotalPrice.ReadOnly = true;
            TotalPrice.Width = 125;
            // 
            // TotalPaid
            // 
            TotalPaid.HeaderText = "Toplam Ödenen";
            TotalPaid.MinimumWidth = 6;
            TotalPaid.Name = "TotalPaid";
            TotalPaid.ReadOnly = true;
            TotalPaid.Width = 125;
            // 
            // SaleStatus
            // 
            SaleStatus.HeaderText = "Durum";
            SaleStatus.MinimumWidth = 6;
            SaleStatus.Name = "SaleStatus";
            SaleStatus.ReadOnly = true;
            SaleStatus.Width = 125;
            // 
            // Date
            // 
            Date.HeaderText = "Tarih/Saat";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 150;
            // 
            // paymentActivitiesPanel
            // 
            paymentActivitiesPanel.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            paymentActivitiesPanel.Controls.Add(label2);
            paymentActivitiesPanel.Controls.Add(paymentActivitiesDataGridView);
            paymentActivitiesPanel.Location = new System.Drawing.Point(1044, 81);
            paymentActivitiesPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            paymentActivitiesPanel.Name = "paymentActivitiesPanel";
            paymentActivitiesPanel.Size = new System.Drawing.Size(601, 552);
            paymentActivitiesPanel.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(231, 14);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(118, 31);
            label2.TabIndex = 1;
            label2.Text = "Ödemeler";
            // 
            // paymentActivitiesDataGridView
            // 
            paymentActivitiesDataGridView.AllowUserToAddRows = false;
            paymentActivitiesDataGridView.AllowUserToDeleteRows = false;
            paymentActivitiesDataGridView.AllowUserToOrderColumns = true;
            paymentActivitiesDataGridView.AllowUserToResizeColumns = false;
            paymentActivitiesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(204, 204, 204);
            paymentActivitiesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            paymentActivitiesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(86, 161, 191);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(250, 250, 250);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            paymentActivitiesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            paymentActivitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            paymentActivitiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { PayCode, Paid, PaymentMethod, DateTime });
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(104, 166, 250);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            paymentActivitiesDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            paymentActivitiesDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            paymentActivitiesDataGridView.EnableHeadersVisualStyles = false;
            paymentActivitiesDataGridView.Location = new System.Drawing.Point(0, 60);
            paymentActivitiesDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            paymentActivitiesDataGridView.Name = "paymentActivitiesDataGridView";
            paymentActivitiesDataGridView.ReadOnly = true;
            paymentActivitiesDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            paymentActivitiesDataGridView.RowHeadersWidth = 51;
            paymentActivitiesDataGridView.RowTemplate.Height = 24;
            paymentActivitiesDataGridView.Size = new System.Drawing.Size(601, 492);
            paymentActivitiesDataGridView.TabIndex = 0;
            // 
            // PayCode
            // 
            PayCode.HeaderText = "Ödeme Kodu";
            PayCode.MinimumWidth = 6;
            PayCode.Name = "PayCode";
            PayCode.ReadOnly = true;
            PayCode.Width = 150;
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
            // DateTime
            // 
            DateTime.HeaderText = "Tarih/Saat";
            DateTime.MinimumWidth = 6;
            DateTime.Name = "DateTime";
            DateTime.ReadOnly = true;
            DateTime.Width = 150;
            // 
            // tableComboBox
            // 
            tableComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tableComboBox.FormattingEnabled = true;
            tableComboBox.Location = new System.Drawing.Point(1099, 35);
            tableComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableComboBox.Name = "tableComboBox";
            tableComboBox.Size = new System.Drawing.Size(243, 31);
            tableComboBox.TabIndex = 32;
            // 
            // searchDetailsPictureBox
            // 
            searchDetailsPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            searchDetailsPictureBox.Image = (System.Drawing.Image)resources.GetObject("searchDetailsPictureBox.Image");
            searchDetailsPictureBox.Location = new System.Drawing.Point(1358, 29);
            searchDetailsPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            searchDetailsPictureBox.Name = "searchDetailsPictureBox";
            searchDetailsPictureBox.Size = new System.Drawing.Size(35, 44);
            searchDetailsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            searchDetailsPictureBox.TabIndex = 31;
            searchDetailsPictureBox.TabStop = false;
            searchDetailsPictureBox.Click += searchDetailsPictureBox_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(1042, 39);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(51, 23);
            label6.TabIndex = 30;
            label6.Text = "Masa";
            // 
            // updateStockPanel
            // 
            updateStockPanel.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            updateStockPanel.Controls.Add(discountTotalTextBox);
            updateStockPanel.Controls.Add(label11);
            updateStockPanel.Controls.Add(DeleteDiscountButton);
            updateStockPanel.Controls.Add(AddDiscountButton);
            updateStockPanel.Controls.Add(fullTableComboBox);
            updateStockPanel.Controls.Add(label5);
            updateStockPanel.Controls.Add(label3);
            updateStockPanel.Location = new System.Drawing.Point(49, 669);
            updateStockPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            updateStockPanel.Name = "updateStockPanel";
            updateStockPanel.Size = new System.Drawing.Size(583, 170);
            updateStockPanel.TabIndex = 33;
            // 
            // discountTotalTextBox
            // 
            discountTotalTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            discountTotalTextBox.Location = new System.Drawing.Point(90, 112);
            discountTotalTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            discountTotalTextBox.Name = "discountTotalTextBox";
            discountTotalTextBox.Size = new System.Drawing.Size(146, 30);
            discountTotalTextBox.TabIndex = 38;
            discountTotalTextBox.TextChanged += discountTotalTextBox_TextChanged;
            discountTotalTextBox.KeyPress += discountTotalTextBox_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label11.ForeColor = System.Drawing.Color.White;
            label11.Location = new System.Drawing.Point(32, 115);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(52, 23);
            label11.TabIndex = 37;
            label11.Text = "Tutar";
            // 
            // DeleteDiscountButton
            // 
            DeleteDiscountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            DeleteDiscountButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            DeleteDiscountButton.Location = new System.Drawing.Point(451, 112);
            DeleteDiscountButton.Name = "DeleteDiscountButton";
            DeleteDiscountButton.Size = new System.Drawing.Size(120, 35);
            DeleteDiscountButton.TabIndex = 36;
            DeleteDiscountButton.Text = "İptal";
            DeleteDiscountButton.UseVisualStyleBackColor = true;
            DeleteDiscountButton.Click += DeleteDiscountButton_Click;
            // 
            // AddDiscountButton
            // 
            AddDiscountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            AddDiscountButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            AddDiscountButton.Location = new System.Drawing.Point(451, 51);
            AddDiscountButton.Name = "AddDiscountButton";
            AddDiscountButton.Size = new System.Drawing.Size(120, 35);
            AddDiscountButton.TabIndex = 34;
            AddDiscountButton.Text = "Ekle";
            AddDiscountButton.UseVisualStyleBackColor = true;
            AddDiscountButton.Click += AddDiscountButton_Click;
            // 
            // fullTableComboBox
            // 
            fullTableComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            fullTableComboBox.FormattingEnabled = true;
            fullTableComboBox.Location = new System.Drawing.Point(90, 55);
            fullTableComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            fullTableComboBox.Name = "fullTableComboBox";
            fullTableComboBox.Size = new System.Drawing.Size(243, 31);
            fullTableComboBox.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(33, 59);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(51, 23);
            label5.TabIndex = 34;
            label5.Text = "Masa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(196, 11);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(191, 31);
            label3.TabIndex = 1;
            label3.Text = "İndirim İşlemleri";
            // 
            // Sales
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(5, 41, 64);
            ClientSize = new System.Drawing.Size(1656, 1055);
            Controls.Add(updateStockPanel);
            Controls.Add(tableComboBox);
            Controls.Add(searchDetailsPictureBox);
            Controls.Add(label6);
            Controls.Add(paymentActivitiesPanel);
            Controls.Add(salesPanel);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Sales";
            Text = "Sales";
            Load += Sales_Load;
            salesPanel.ResumeLayout(false);
            salesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)salesDataGridView).EndInit();
            paymentActivitiesPanel.ResumeLayout(false);
            paymentActivitiesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)paymentActivitiesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchDetailsPictureBox).EndInit();
            updateStockPanel.ResumeLayout(false);
            updateStockPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel salesPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView salesDataGridView;
        private System.Windows.Forms.Panel paymentActivitiesPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView paymentActivitiesDataGridView;
        private System.Windows.Forms.ComboBox tableComboBox;
        private System.Windows.Forms.PictureBox searchDetailsPictureBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private System.Windows.Forms.Panel updateStockPanel;
        private System.Windows.Forms.ComboBox fullTableComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddDiscountButton;
        private System.Windows.Forms.Button DeleteDiscountButton;
        private System.Windows.Forms.TextBox discountTotalTextBox;
        private System.Windows.Forms.Label label11;
    }
}