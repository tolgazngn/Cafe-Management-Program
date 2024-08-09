namespace CafeMax.Forms.Management
{
    partial class ProductInfos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInfos));
            productsPanel = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            productsDataGridView = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ProductMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            menusComboBox = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            deletePictureBox = new System.Windows.Forms.PictureBox();
            selectedProductTextBox = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            productsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deletePictureBox).BeginInit();
            SuspendLayout();
            // 
            // productsPanel
            // 
            productsPanel.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            productsPanel.Controls.Add(label1);
            productsPanel.Controls.Add(productsDataGridView);
            productsPanel.Location = new System.Drawing.Point(83, 137);
            productsPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            productsPanel.Name = "productsPanel";
            productsPanel.Size = new System.Drawing.Size(955, 552);
            productsPanel.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(407, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(116, 38);
            label1.TabIndex = 1;
            label1.Text = "Ürünler";
            // 
            // productsDataGridView
            // 
            productsDataGridView.AllowUserToAddRows = false;
            productsDataGridView.AllowUserToDeleteRows = false;
            productsDataGridView.AllowUserToOrderColumns = true;
            productsDataGridView.AllowUserToResizeColumns = false;
            productsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(204, 204, 204);
            productsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            productsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(86, 161, 191);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(250, 250, 250);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            productsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, ProductName, UnitPrice, ProductMenu, Stock, Description });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(104, 166, 250);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            productsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            productsDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            productsDataGridView.EnableHeadersVisualStyles = false;
            productsDataGridView.Location = new System.Drawing.Point(0, 55);
            productsDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            productsDataGridView.Name = "productsDataGridView";
            productsDataGridView.ReadOnly = true;
            productsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            productsDataGridView.RowHeadersWidth = 51;
            productsDataGridView.RowTemplate.Height = 24;
            productsDataGridView.Size = new System.Drawing.Size(955, 497);
            productsDataGridView.TabIndex = 0;
            productsDataGridView.CellContentClick += productsDataGridView_CellContentClick;
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
            // ProductName
            // 
            ProductName.HeaderText = "Ürün Adı";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Width = 200;
            // 
            // UnitPrice
            // 
            UnitPrice.HeaderText = "Birim Fiyat";
            UnitPrice.MinimumWidth = 6;
            UnitPrice.Name = "UnitPrice";
            UnitPrice.ReadOnly = true;
            UnitPrice.Width = 125;
            // 
            // ProductMenu
            // 
            ProductMenu.HeaderText = "Menü";
            ProductMenu.MinimumWidth = 6;
            ProductMenu.Name = "ProductMenu";
            ProductMenu.ReadOnly = true;
            ProductMenu.Width = 200;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stok";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            Stock.Width = 125;
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
            // menusComboBox
            // 
            menusComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            menusComboBox.FormattingEnabled = true;
            menusComboBox.Location = new System.Drawing.Point(146, 86);
            menusComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            menusComboBox.Name = "menusComboBox";
            menusComboBox.Size = new System.Drawing.Size(215, 31);
            menusComboBox.TabIndex = 32;
            menusComboBox.SelectedIndexChanged += menusComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(85, 89);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(55, 23);
            label3.TabIndex = 33;
            label3.Text = "Menü";
            // 
            // deletePictureBox
            // 
            deletePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            deletePictureBox.Image = (System.Drawing.Image)resources.GetObject("deletePictureBox.Image");
            deletePictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            deletePictureBox.Location = new System.Drawing.Point(1057, 137);
            deletePictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            deletePictureBox.Name = "deletePictureBox";
            deletePictureBox.Size = new System.Drawing.Size(40, 40);
            deletePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            deletePictureBox.TabIndex = 34;
            deletePictureBox.TabStop = false;
            deletePictureBox.Click += deletePictureBox_Click;
            // 
            // selectedProductTextBox
            // 
            selectedProductTextBox.Enabled = false;
            selectedProductTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            selectedProductTextBox.Location = new System.Drawing.Point(813, 89);
            selectedProductTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            selectedProductTextBox.Name = "selectedProductTextBox";
            selectedProductTextBox.ReadOnly = true;
            selectedProductTextBox.Size = new System.Drawing.Size(225, 30);
            selectedProductTextBox.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(699, 92);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(110, 23);
            label7.TabIndex = 35;
            label7.Text = "Seçilen Ürün";
            // 
            // ProductInfos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(0, 31, 63);
            ClientSize = new System.Drawing.Size(1656, 1055);
            Controls.Add(selectedProductTextBox);
            Controls.Add(label7);
            Controls.Add(deletePictureBox);
            Controls.Add(menusComboBox);
            Controls.Add(label3);
            Controls.Add(productsPanel);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "ProductInfos";
            Text = "ProductInfos";
            Load += ProductInfos_Load;
            productsPanel.ResumeLayout(false);
            productsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)deletePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel productsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.ComboBox menusComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox deletePictureBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.TextBox selectedProductTextBox;
        private System.Windows.Forms.Label label7;
    }
}