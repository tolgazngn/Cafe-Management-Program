namespace CafeMax
{
    partial class StockTracking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockTracking));
            stockPanel = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            stockDataGridView = new System.Windows.Forms.DataGridView();
            ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ProductMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            updateStockPanel = new System.Windows.Forms.Panel();
            selectedProductTextBox = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            enterPictureBox = new System.Windows.Forms.PictureBox();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            menusComboBox = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            stockPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stockDataGridView).BeginInit();
            updateStockPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)amountNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enterPictureBox).BeginInit();
            SuspendLayout();
            // 
            // stockPanel
            // 
            stockPanel.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            stockPanel.Controls.Add(label2);
            stockPanel.Controls.Add(stockDataGridView);
            stockPanel.Location = new System.Drawing.Point(68, 111);
            stockPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            stockPanel.Name = "stockPanel";
            stockPanel.Size = new System.Drawing.Size(596, 552);
            stockPanel.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(244, 11);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(62, 31);
            label2.TabIndex = 1;
            label2.Text = "Stok";
            // 
            // stockDataGridView
            // 
            stockDataGridView.AllowUserToAddRows = false;
            stockDataGridView.AllowUserToDeleteRows = false;
            stockDataGridView.AllowUserToOrderColumns = true;
            stockDataGridView.AllowUserToResizeColumns = false;
            stockDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(204, 204, 204);
            stockDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            stockDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(86, 161, 191);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(250, 250, 250);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            stockDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            stockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            stockDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ProductName, ProductMenu, UnitPrice, Stock });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(104, 166, 250);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            stockDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            stockDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            stockDataGridView.EnableHeadersVisualStyles = false;
            stockDataGridView.Location = new System.Drawing.Point(0, 46);
            stockDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            stockDataGridView.Name = "stockDataGridView";
            stockDataGridView.ReadOnly = true;
            stockDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            stockDataGridView.RowHeadersWidth = 51;
            stockDataGridView.RowTemplate.Height = 24;
            stockDataGridView.Size = new System.Drawing.Size(596, 506);
            stockDataGridView.TabIndex = 0;
            stockDataGridView.CellContentClick += stockDataGridView_CellContentClick;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Ürün Adı";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Width = 175;
            // 
            // ProductMenu
            // 
            ProductMenu.HeaderText = "Menü";
            ProductMenu.MinimumWidth = 6;
            ProductMenu.Name = "ProductMenu";
            ProductMenu.ReadOnly = true;
            ProductMenu.Width = 125;
            // 
            // UnitPrice
            // 
            UnitPrice.HeaderText = "Birim Fiyat";
            UnitPrice.MinimumWidth = 6;
            UnitPrice.Name = "UnitPrice";
            UnitPrice.ReadOnly = true;
            UnitPrice.Width = 125;
            // 
            // Stock
            // 
            Stock.HeaderText = "Adet";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            Stock.Width = 125;
            // 
            // updateStockPanel
            // 
            updateStockPanel.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            updateStockPanel.Controls.Add(selectedProductTextBox);
            updateStockPanel.Controls.Add(label7);
            updateStockPanel.Controls.Add(amountNumericUpDown);
            updateStockPanel.Controls.Add(enterPictureBox);
            updateStockPanel.Controls.Add(label4);
            updateStockPanel.Controls.Add(label6);
            updateStockPanel.Location = new System.Drawing.Point(707, 111);
            updateStockPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            updateStockPanel.Name = "updateStockPanel";
            updateStockPanel.Size = new System.Drawing.Size(473, 373);
            updateStockPanel.TabIndex = 6;
            // 
            // selectedProductTextBox
            // 
            selectedProductTextBox.Enabled = false;
            selectedProductTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            selectedProductTextBox.Location = new System.Drawing.Point(168, 125);
            selectedProductTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            selectedProductTextBox.Name = "selectedProductTextBox";
            selectedProductTextBox.ReadOnly = true;
            selectedProductTextBox.Size = new System.Drawing.Size(225, 30);
            selectedProductTextBox.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(54, 128);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(110, 23);
            label7.TabIndex = 13;
            label7.Text = "Seçilen Ürün";
            // 
            // amountNumericUpDown
            // 
            amountNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            amountNumericUpDown.Location = new System.Drawing.Point(168, 199);
            amountNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            amountNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            amountNumericUpDown.Name = "amountNumericUpDown";
            amountNumericUpDown.Size = new System.Drawing.Size(146, 30);
            amountNumericUpDown.TabIndex = 7;
            amountNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // enterPictureBox
            // 
            enterPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            enterPictureBox.Image = (System.Drawing.Image)resources.GetObject("enterPictureBox.Image");
            enterPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            enterPictureBox.Location = new System.Drawing.Point(213, 270);
            enterPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            enterPictureBox.Name = "enterPictureBox";
            enterPictureBox.Size = new System.Drawing.Size(60, 60);
            enterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            enterPictureBox.TabIndex = 4;
            enterPictureBox.TabStop = false;
            enterPictureBox.Click += enterPictureBox_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(14, 201);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(148, 23);
            label4.TabIndex = 1;
            label4.Text = "Eklenecek Miktar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(168, 11);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(161, 31);
            label6.TabIndex = 1;
            label6.Text = "Stok Güncelle";
            label6.Click += label6_Click;
            // 
            // menusComboBox
            // 
            menusComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            menusComboBox.FormattingEnabled = true;
            menusComboBox.Location = new System.Drawing.Point(129, 67);
            menusComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            menusComboBox.Name = "menusComboBox";
            menusComboBox.Size = new System.Drawing.Size(146, 31);
            menusComboBox.TabIndex = 3;
            menusComboBox.SelectedIndexChanged += menusComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(68, 70);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(55, 23);
            label3.TabIndex = 8;
            label3.Text = "Menü";
            // 
            // StockTracking
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(0, 31, 63);
            ClientSize = new System.Drawing.Size(1656, 1055);
            Controls.Add(menusComboBox);
            Controls.Add(label3);
            Controls.Add(updateStockPanel);
            Controls.Add(stockPanel);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "StockTracking";
            Text = "StockTracking";
            Load += StockTracking_Load;
            stockPanel.ResumeLayout(false);
            stockPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)stockDataGridView).EndInit();
            updateStockPanel.ResumeLayout(false);
            updateStockPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)amountNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)enterPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel stockPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView stockDataGridView;
        private System.Windows.Forms.Panel updateStockPanel;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
        private System.Windows.Forms.PictureBox enterPictureBox;
        private System.Windows.Forms.ComboBox menusComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox MenusComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox selectedProductTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
    }
}