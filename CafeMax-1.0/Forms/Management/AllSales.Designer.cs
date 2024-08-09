namespace CafeMax.Forms.Management
{
    partial class AllSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllSales));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            allRowsCheckBox = new System.Windows.Forms.CheckBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            secondDateTimePicker = new System.Windows.Forms.DateTimePicker();
            firstDateTimePicker = new System.Windows.Forms.DateTimePicker();
            salesPanel = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            salesDataGridView = new System.Windows.Forms.DataGridView();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            searchPictureBox = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            paymentsDataGridView = new System.Windows.Forms.DataGridView();
            SaleCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TotalPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SaleStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PaymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            salesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)salesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchPictureBox).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)paymentsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // allRowsCheckBox
            // 
            allRowsCheckBox.AutoSize = true;
            allRowsCheckBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            allRowsCheckBox.ForeColor = System.Drawing.Color.White;
            allRowsCheckBox.Location = new System.Drawing.Point(681, 115);
            allRowsCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            allRowsCheckBox.Name = "allRowsCheckBox";
            allRowsCheckBox.Size = new System.Drawing.Size(134, 27);
            allRowsCheckBox.TabIndex = 24;
            allRowsCheckBox.Text = "Tüm Kayıtlar";
            allRowsCheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(356, 113);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(45, 23);
            label5.TabIndex = 18;
            label5.Text = "Bitiş";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(24, 113);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(85, 23);
            label4.TabIndex = 19;
            label4.Text = "Başlangıç";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(23, 63);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 28);
            label3.TabIndex = 20;
            label3.Text = "Tarih";
            // 
            // secondDateTimePicker
            // 
            secondDateTimePicker.Location = new System.Drawing.Point(407, 115);
            secondDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            secondDateTimePicker.Name = "secondDateTimePicker";
            secondDateTimePicker.Size = new System.Drawing.Size(200, 27);
            secondDateTimePicker.TabIndex = 15;
            // 
            // firstDateTimePicker
            // 
            firstDateTimePicker.Location = new System.Drawing.Point(115, 115);
            firstDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            firstDateTimePicker.Name = "firstDateTimePicker";
            firstDateTimePicker.Size = new System.Drawing.Size(200, 27);
            firstDateTimePicker.TabIndex = 16;
            // 
            // salesPanel
            // 
            salesPanel.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            salesPanel.Controls.Add(label1);
            salesPanel.Controls.Add(salesDataGridView);
            salesPanel.Location = new System.Drawing.Point(28, 182);
            salesPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            salesPanel.Name = "salesPanel";
            salesPanel.Size = new System.Drawing.Size(1081, 637);
            salesPanel.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(446, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(113, 38);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(86, 161, 191);
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(250, 250, 250);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            salesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            salesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            salesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { SaleCode, TableName, Discount, TotalPrice, TotalPaid, SaleStatus, Date });
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(104, 166, 250);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            salesDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            salesDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            salesDataGridView.EnableHeadersVisualStyles = false;
            salesDataGridView.Location = new System.Drawing.Point(0, 51);
            salesDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            salesDataGridView.Name = "salesDataGridView";
            salesDataGridView.ReadOnly = true;
            salesDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            salesDataGridView.RowHeadersWidth = 51;
            salesDataGridView.RowTemplate.Height = 24;
            salesDataGridView.Size = new System.Drawing.Size(1081, 586);
            salesDataGridView.TabIndex = 0;
            salesDataGridView.CellContentClick += salesDataGridView_CellContentClick;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(915, 1334);
            pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(35, 44);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // searchPictureBox
            // 
            searchPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            searchPictureBox.Image = (System.Drawing.Image)resources.GetObject("searchPictureBox.Image");
            searchPictureBox.Location = new System.Drawing.Point(821, 105);
            searchPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            searchPictureBox.Name = "searchPictureBox";
            searchPictureBox.Size = new System.Drawing.Size(35, 44);
            searchPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            searchPictureBox.TabIndex = 29;
            searchPictureBox.TabStop = false;
            searchPictureBox.Click += searchPictureBox_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(paymentsDataGridView);
            panel1.Location = new System.Drawing.Point(1127, 182);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(480, 637);
            panel1.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(155, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(145, 38);
            label2.TabIndex = 1;
            label2.Text = "Ödemeler";
            // 
            // paymentsDataGridView
            // 
            paymentsDataGridView.AllowUserToAddRows = false;
            paymentsDataGridView.AllowUserToDeleteRows = false;
            paymentsDataGridView.AllowUserToOrderColumns = true;
            paymentsDataGridView.AllowUserToResizeColumns = false;
            paymentsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(204, 204, 204);
            paymentsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            paymentsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(86, 161, 191);
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(250, 250, 250);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            paymentsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            paymentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            paymentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Paid, PaymentType, PaymentDate });
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(104, 166, 250);
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            paymentsDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            paymentsDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            paymentsDataGridView.EnableHeadersVisualStyles = false;
            paymentsDataGridView.Location = new System.Drawing.Point(0, 51);
            paymentsDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            paymentsDataGridView.Name = "paymentsDataGridView";
            paymentsDataGridView.ReadOnly = true;
            paymentsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            paymentsDataGridView.RowHeadersWidth = 51;
            paymentsDataGridView.RowTemplate.Height = 24;
            paymentsDataGridView.Size = new System.Drawing.Size(480, 586);
            paymentsDataGridView.TabIndex = 0;
            // 
            // SaleCode
            // 
            SaleCode.HeaderText = "Satış Kodu";
            SaleCode.MinimumWidth = 6;
            SaleCode.Name = "SaleCode";
            SaleCode.ReadOnly = true;
            SaleCode.Width = 200;
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
            Date.Width = 220;
            // 
            // Paid
            // 
            Paid.HeaderText = "Ödenen";
            Paid.MinimumWidth = 6;
            Paid.Name = "Paid";
            Paid.ReadOnly = true;
            Paid.Width = 125;
            // 
            // PaymentType
            // 
            PaymentType.HeaderText = "Ödeme Türü";
            PaymentType.MinimumWidth = 6;
            PaymentType.Name = "PaymentType";
            PaymentType.ReadOnly = true;
            PaymentType.Width = 150;
            // 
            // PaymentDate
            // 
            PaymentDate.HeaderText = "Tarih";
            PaymentDate.MinimumWidth = 6;
            PaymentDate.Name = "PaymentDate";
            PaymentDate.ReadOnly = true;
            PaymentDate.Width = 155;
            // 
            // AllSales
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(5, 41, 64);
            ClientSize = new System.Drawing.Size(1656, 1055);
            Controls.Add(panel1);
            Controls.Add(searchPictureBox);
            Controls.Add(allRowsCheckBox);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(secondDateTimePicker);
            Controls.Add(firstDateTimePicker);
            Controls.Add(salesPanel);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "AllSales";
            Text = "Sales";
            Load += AllSales_Load;
            salesPanel.ResumeLayout(false);
            salesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)salesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchPictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)paymentsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckBox allRowsCheckBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker secondDateTimePicker;
        private System.Windows.Forms.DateTimePicker firstDateTimePicker;
        private System.Windows.Forms.Panel salesPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView salesDataGridView;
        private System.Windows.Forms.PictureBox searchPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView paymentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentDate;
    }
}