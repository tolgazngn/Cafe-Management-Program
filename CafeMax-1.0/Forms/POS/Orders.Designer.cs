namespace CafeMax
{
    partial class Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            ordersPanel = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            ordersDataGridView = new System.Windows.Forms.DataGridView();
            OrderCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            OrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            orderDetailsPanel = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            orderDetailsDataGridView = new System.Windows.Forms.DataGridView();
            searchDetailsPictureBox = new System.Windows.Forms.PictureBox();
            label6 = new System.Windows.Forms.Label();
            tableComboBox = new System.Windows.Forms.ComboBox();
            productCancellationButton = new System.Windows.Forms.Button();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ordersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).BeginInit();
            orderDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderDetailsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchDetailsPictureBox).BeginInit();
            SuspendLayout();
            // 
            // ordersPanel
            // 
            ordersPanel.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            ordersPanel.Controls.Add(label1);
            ordersPanel.Controls.Add(ordersDataGridView);
            ordersPanel.Location = new System.Drawing.Point(29, 133);
            ordersPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ordersPanel.Name = "ordersPanel";
            ordersPanel.Size = new System.Drawing.Size(619, 552);
            ordersPanel.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(228, 14);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(114, 31);
            label1.TabIndex = 1;
            label1.Text = "Siparişler";
            label1.Click += label1_Click;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(86, 161, 191);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(250, 250, 250);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            ordersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { OrderCode, TableName, Date, OrderStatus });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(104, 166, 250);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            ordersDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            ordersDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            ordersDataGridView.EnableHeadersVisualStyles = false;
            ordersDataGridView.Location = new System.Drawing.Point(0, 60);
            ordersDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ordersDataGridView.Name = "ordersDataGridView";
            ordersDataGridView.ReadOnly = true;
            ordersDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            ordersDataGridView.RowHeadersWidth = 51;
            ordersDataGridView.RowTemplate.Height = 24;
            ordersDataGridView.Size = new System.Drawing.Size(619, 492);
            ordersDataGridView.TabIndex = 0;
            // 
            // OrderCode
            // 
            OrderCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            OrderCode.HeaderText = "Sipariş Kodu";
            OrderCode.MinimumWidth = 6;
            OrderCode.Name = "OrderCode";
            OrderCode.ReadOnly = true;
            OrderCode.Width = 200;
            // 
            // TableName
            // 
            TableName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            TableName.HeaderText = "Masa Adı";
            TableName.MinimumWidth = 6;
            TableName.Name = "TableName";
            TableName.ReadOnly = true;
            TableName.Width = 109;
            // 
            // Date
            // 
            Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            Date.HeaderText = "Tarih/Saat";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 114;
            // 
            // OrderStatus
            // 
            OrderStatus.HeaderText = "Sipariş Durumu";
            OrderStatus.MinimumWidth = 6;
            OrderStatus.Name = "OrderStatus";
            OrderStatus.ReadOnly = true;
            OrderStatus.Width = 150;
            // 
            // orderDetailsPanel
            // 
            orderDetailsPanel.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            orderDetailsPanel.Controls.Add(label2);
            orderDetailsPanel.Controls.Add(orderDetailsDataGridView);
            orderDetailsPanel.Location = new System.Drawing.Point(708, 133);
            orderDetailsPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            orderDetailsPanel.Name = "orderDetailsPanel";
            orderDetailsPanel.Size = new System.Drawing.Size(606, 552);
            orderDetailsPanel.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(209, 14);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(189, 31);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(86, 161, 191);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(250, 250, 250);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            orderDetailsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            orderDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, ProductName, Amount, UnitPrice, TotalPrice });
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(104, 166, 250);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            orderDetailsDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            orderDetailsDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            orderDetailsDataGridView.EnableHeadersVisualStyles = false;
            orderDetailsDataGridView.Location = new System.Drawing.Point(0, 60);
            orderDetailsDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            orderDetailsDataGridView.Name = "orderDetailsDataGridView";
            orderDetailsDataGridView.ReadOnly = true;
            orderDetailsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            orderDetailsDataGridView.RowHeadersWidth = 51;
            orderDetailsDataGridView.RowTemplate.Height = 24;
            orderDetailsDataGridView.Size = new System.Drawing.Size(606, 492);
            orderDetailsDataGridView.TabIndex = 0;
            orderDetailsDataGridView.CellContentClick += orderDetailsDataGridView_CellContentClick;
            // 
            // searchDetailsPictureBox
            // 
            searchDetailsPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            searchDetailsPictureBox.Image = (System.Drawing.Image)resources.GetObject("searchDetailsPictureBox.Image");
            searchDetailsPictureBox.Location = new System.Drawing.Point(1020, 78);
            searchDetailsPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            searchDetailsPictureBox.Name = "searchDetailsPictureBox";
            searchDetailsPictureBox.Size = new System.Drawing.Size(35, 44);
            searchDetailsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            searchDetailsPictureBox.TabIndex = 28;
            searchDetailsPictureBox.TabStop = false;
            searchDetailsPictureBox.Click += searchDetailsPictureBox_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(704, 88);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(51, 23);
            label6.TabIndex = 26;
            label6.Text = "Masa";
            // 
            // tableComboBox
            // 
            tableComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tableComboBox.FormattingEnabled = true;
            tableComboBox.Location = new System.Drawing.Point(761, 84);
            tableComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableComboBox.Name = "tableComboBox";
            tableComboBox.Size = new System.Drawing.Size(243, 31);
            tableComboBox.TabIndex = 29;
            // 
            // productCancellationButton
            // 
            productCancellationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            productCancellationButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            productCancellationButton.Location = new System.Drawing.Point(1367, 133);
            productCancellationButton.Name = "productCancellationButton";
            productCancellationButton.Size = new System.Drawing.Size(189, 63);
            productCancellationButton.TabIndex = 30;
            productCancellationButton.Text = "Ürün İptal";
            productCancellationButton.UseVisualStyleBackColor = true;
            productCancellationButton.Click += productCancellationButton_Click;
            // 
            // Id
            // 
            Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 50;
            // 
            // ProductName
            // 
            ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            ProductName.HeaderText = "Ürün Adı";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Width = 175;
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
            TotalPrice.Width = 150;
            // 
            // Orders
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(5, 41, 64);
            ClientSize = new System.Drawing.Size(1703, 1055);
            Controls.Add(productCancellationButton);
            Controls.Add(tableComboBox);
            Controls.Add(searchDetailsPictureBox);
            Controls.Add(label6);
            Controls.Add(orderDetailsPanel);
            Controls.Add(ordersPanel);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Orders";
            Text = "Orders";
            Load += Orders_Load;
            ordersPanel.ResumeLayout(false);
            ordersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).EndInit();
            orderDetailsPanel.ResumeLayout(false);
            orderDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderDetailsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchDetailsPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel ordersPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.Panel orderDetailsPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView orderDetailsDataGridView;
        private System.Windows.Forms.PictureBox searchDetailsPictureBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox tableComboBox;
        private System.Windows.Forms.Button productCancellationButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
    }
}