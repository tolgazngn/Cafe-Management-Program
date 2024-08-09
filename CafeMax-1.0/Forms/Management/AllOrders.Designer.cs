namespace CafeMax.Forms.Management
{
    partial class AllOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllOrders));
            orderDetailsPanel = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            orderDetailsDataGridView = new System.Windows.Forms.DataGridView();
            ordersPanel = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            ordersDataGridView = new System.Windows.Forms.DataGridView();
            allRowsCheckBox = new System.Windows.Forms.CheckBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            secondDateTimePicker = new System.Windows.Forms.DateTimePicker();
            firstDateTimePicker = new System.Windows.Forms.DateTimePicker();
            searchOrdersPictureBox = new System.Windows.Forms.PictureBox();
            OrderCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            OrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            orderDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderDetailsDataGridView).BeginInit();
            ordersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchOrdersPictureBox).BeginInit();
            SuspendLayout();
            // 
            // orderDetailsPanel
            // 
            orderDetailsPanel.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            orderDetailsPanel.Controls.Add(label2);
            orderDetailsPanel.Controls.Add(orderDetailsDataGridView);
            orderDetailsPanel.Location = new System.Drawing.Point(996, 173);
            orderDetailsPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            orderDetailsPanel.Name = "orderDetailsPanel";
            orderDetailsPanel.Size = new System.Drawing.Size(599, 650);
            orderDetailsPanel.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(195, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(231, 38);
            label2.TabIndex = 1;
            label2.Text = "Sipariş Detayları";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(86, 161, 191);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(250, 250, 250);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            orderDetailsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            orderDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ProductName, Amount, UnitPrice, TotalPrice });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(104, 166, 250);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            orderDetailsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            orderDetailsDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            orderDetailsDataGridView.EnableHeadersVisualStyles = false;
            orderDetailsDataGridView.Location = new System.Drawing.Point(0, 51);
            orderDetailsDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            orderDetailsDataGridView.Name = "orderDetailsDataGridView";
            orderDetailsDataGridView.ReadOnly = true;
            orderDetailsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            orderDetailsDataGridView.RowHeadersWidth = 51;
            orderDetailsDataGridView.RowTemplate.Height = 24;
            orderDetailsDataGridView.Size = new System.Drawing.Size(599, 599);
            orderDetailsDataGridView.TabIndex = 0;
            // 
            // ordersPanel
            // 
            ordersPanel.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            ordersPanel.Controls.Add(label1);
            ordersPanel.Controls.Add(ordersDataGridView);
            ordersPanel.Location = new System.Drawing.Point(35, 173);
            ordersPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ordersPanel.Name = "ordersPanel";
            ordersPanel.Size = new System.Drawing.Size(884, 650);
            ordersPanel.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(347, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(138, 38);
            label1.TabIndex = 1;
            label1.Text = "Siparişler";
            // 
            // ordersDataGridView
            // 
            ordersDataGridView.AllowUserToAddRows = false;
            ordersDataGridView.AllowUserToDeleteRows = false;
            ordersDataGridView.AllowUserToOrderColumns = true;
            ordersDataGridView.AllowUserToResizeColumns = false;
            ordersDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(204, 204, 204);
            ordersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            ordersDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(86, 161, 191);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(250, 250, 250);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            ordersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { OrderCode, TableName, OrderStatus, Date });
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(104, 166, 250);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            ordersDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            ordersDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            ordersDataGridView.EnableHeadersVisualStyles = false;
            ordersDataGridView.Location = new System.Drawing.Point(0, 51);
            ordersDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ordersDataGridView.Name = "ordersDataGridView";
            ordersDataGridView.ReadOnly = true;
            ordersDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            ordersDataGridView.RowHeadersWidth = 51;
            ordersDataGridView.RowTemplate.Height = 24;
            ordersDataGridView.Size = new System.Drawing.Size(884, 599);
            ordersDataGridView.TabIndex = 0;
            ordersDataGridView.CellContentClick += ordersDataGridView_CellContentClick;
            // 
            // allRowsCheckBox
            // 
            allRowsCheckBox.AutoSize = true;
            allRowsCheckBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            allRowsCheckBox.ForeColor = System.Drawing.Color.White;
            allRowsCheckBox.Location = new System.Drawing.Point(688, 122);
            allRowsCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            allRowsCheckBox.Name = "allRowsCheckBox";
            allRowsCheckBox.Size = new System.Drawing.Size(134, 27);
            allRowsCheckBox.TabIndex = 31;
            allRowsCheckBox.Text = "Tüm Kayıtlar";
            allRowsCheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(363, 121);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(45, 23);
            label5.TabIndex = 28;
            label5.Text = "Bitiş";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(31, 121);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(85, 23);
            label4.TabIndex = 29;
            label4.Text = "Başlangıç";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(30, 68);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 28);
            label3.TabIndex = 30;
            label3.Text = "Tarih";
            // 
            // secondDateTimePicker
            // 
            secondDateTimePicker.Location = new System.Drawing.Point(414, 122);
            secondDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            secondDateTimePicker.Name = "secondDateTimePicker";
            secondDateTimePicker.Size = new System.Drawing.Size(200, 27);
            secondDateTimePicker.TabIndex = 26;
            // 
            // firstDateTimePicker
            // 
            firstDateTimePicker.Location = new System.Drawing.Point(122, 122);
            firstDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            firstDateTimePicker.Name = "firstDateTimePicker";
            firstDateTimePicker.Size = new System.Drawing.Size(200, 27);
            firstDateTimePicker.TabIndex = 27;
            // 
            // searchOrdersPictureBox
            // 
            searchOrdersPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            searchOrdersPictureBox.Image = (System.Drawing.Image)resources.GetObject("searchOrdersPictureBox.Image");
            searchOrdersPictureBox.Location = new System.Drawing.Point(848, 117);
            searchOrdersPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            searchOrdersPictureBox.Name = "searchOrdersPictureBox";
            searchOrdersPictureBox.Size = new System.Drawing.Size(35, 44);
            searchOrdersPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            searchOrdersPictureBox.TabIndex = 32;
            searchOrdersPictureBox.TabStop = false;
            searchOrdersPictureBox.Click += searchOrdersPictureBox_Click;
            // 
            // OrderCode
            // 
            OrderCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            OrderCode.HeaderText = "Sipariş Kodu";
            OrderCode.MinimumWidth = 6;
            OrderCode.Name = "OrderCode";
            OrderCode.ReadOnly = true;
            OrderCode.Width = 350;
            // 
            // TableName
            // 
            TableName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            TableName.HeaderText = "Masa Adı";
            TableName.MinimumWidth = 6;
            TableName.Name = "TableName";
            TableName.ReadOnly = true;
            TableName.Width = 150;
            // 
            // OrderStatus
            // 
            OrderStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            OrderStatus.HeaderText = "Sipariş Durumu";
            OrderStatus.MinimumWidth = 6;
            OrderStatus.Name = "OrderStatus";
            OrderStatus.ReadOnly = true;
            OrderStatus.Width = 130;
            // 
            // Date
            // 
            Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            Date.HeaderText = "Tarih/Saat";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 200;
            // 
            // ProductName
            // 
            ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            ProductName.HeaderText = "Ürün Adı";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Width = 200;
            // 
            // Amount
            // 
            Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            Amount.HeaderText = "Miktar";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.Width = 88;
            // 
            // UnitPrice
            // 
            UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            UnitPrice.HeaderText = "Birim Fiyat";
            UnitPrice.MinimumWidth = 6;
            UnitPrice.Name = "UnitPrice";
            UnitPrice.ReadOnly = true;
            UnitPrice.Width = 119;
            // 
            // TotalPrice
            // 
            TotalPrice.HeaderText = "Toplam Fiyat";
            TotalPrice.MinimumWidth = 6;
            TotalPrice.Name = "TotalPrice";
            TotalPrice.ReadOnly = true;
            TotalPrice.Width = 145;
            // 
            // AllOrders
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(5, 41, 64);
            ClientSize = new System.Drawing.Size(1656, 1055);
            Controls.Add(searchOrdersPictureBox);
            Controls.Add(allRowsCheckBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(secondDateTimePicker);
            Controls.Add(firstDateTimePicker);
            Controls.Add(orderDetailsPanel);
            Controls.Add(ordersPanel);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "AllOrders";
            Text = "Orders";
            Load += AllOrders_Load;
            orderDetailsPanel.ResumeLayout(false);
            orderDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderDetailsDataGridView).EndInit();
            ordersPanel.ResumeLayout(false);
            ordersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchOrdersPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel orderDetailsPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView orderDetailsDataGridView;
        private System.Windows.Forms.Panel ordersPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.CheckBox allRowsCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker secondDateTimePicker;
        private System.Windows.Forms.DateTimePicker firstDateTimePicker;
        private System.Windows.Forms.PictureBox searchOrdersPictureBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
    }
}