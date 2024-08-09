using System;

namespace CafeMax
{
    partial class NewOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewOrder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            newOrderPanel = new System.Windows.Forms.Panel();
            deletePictureBox = new System.Windows.Forms.PictureBox();
            selectedProductTextBox = new System.Windows.Forms.TextBox();
            lastEnterPictureBox = new System.Windows.Forms.PictureBox();
            productDataGridView = new System.Windows.Forms.DataGridView();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            orderDataGridView = new System.Windows.Forms.DataGridView();
            ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            enterPictureBox = new System.Windows.Forms.PictureBox();
            menuComboBox = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            fullTableComboBox = new System.Windows.Forms.ComboBox();
            label7 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            addExpensePanel = new System.Windows.Forms.Panel();
            emptyTableComboBox = new System.Windows.Forms.ComboBox();
            label8 = new System.Windows.Forms.Label();
            enterTablePictureBox = new System.Windows.Forms.PictureBox();
            label12 = new System.Windows.Forms.Label();
            newOrderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)deletePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lastEnterPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amountNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enterPictureBox).BeginInit();
            addExpensePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)enterTablePictureBox).BeginInit();
            SuspendLayout();
            // 
            // newOrderPanel
            // 
            newOrderPanel.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            newOrderPanel.Controls.Add(deletePictureBox);
            newOrderPanel.Controls.Add(selectedProductTextBox);
            newOrderPanel.Controls.Add(lastEnterPictureBox);
            newOrderPanel.Controls.Add(productDataGridView);
            newOrderPanel.Controls.Add(pictureBox1);
            newOrderPanel.Controls.Add(orderDataGridView);
            newOrderPanel.Controls.Add(amountNumericUpDown);
            newOrderPanel.Controls.Add(enterPictureBox);
            newOrderPanel.Controls.Add(menuComboBox);
            newOrderPanel.Controls.Add(label4);
            newOrderPanel.Controls.Add(fullTableComboBox);
            newOrderPanel.Controls.Add(label7);
            newOrderPanel.Controls.Add(label5);
            newOrderPanel.Controls.Add(label1);
            newOrderPanel.Controls.Add(label6);
            newOrderPanel.Controls.Add(label3);
            newOrderPanel.Controls.Add(label2);
            newOrderPanel.Location = new System.Drawing.Point(33, 36);
            newOrderPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            newOrderPanel.Name = "newOrderPanel";
            newOrderPanel.Size = new System.Drawing.Size(1157, 812);
            newOrderPanel.TabIndex = 3;
            // 
            // deletePictureBox
            // 
            deletePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            deletePictureBox.Image = (System.Drawing.Image)resources.GetObject("deletePictureBox.Image");
            deletePictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            deletePictureBox.Location = new System.Drawing.Point(1114, 137);
            deletePictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            deletePictureBox.Name = "deletePictureBox";
            deletePictureBox.Size = new System.Drawing.Size(40, 40);
            deletePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            deletePictureBox.TabIndex = 13;
            deletePictureBox.TabStop = false;
            deletePictureBox.Click += deletePictureBox_Click;
            // 
            // selectedProductTextBox
            // 
            selectedProductTextBox.Enabled = false;
            selectedProductTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            selectedProductTextBox.Location = new System.Drawing.Point(114, 629);
            selectedProductTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            selectedProductTextBox.Name = "selectedProductTextBox";
            selectedProductTextBox.ReadOnly = true;
            selectedProductTextBox.Size = new System.Drawing.Size(225, 30);
            selectedProductTextBox.TabIndex = 12;
            // 
            // lastEnterPictureBox
            // 
            lastEnterPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            lastEnterPictureBox.Image = (System.Drawing.Image)resources.GetObject("lastEnterPictureBox.Image");
            lastEnterPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lastEnterPictureBox.Location = new System.Drawing.Point(808, 679);
            lastEnterPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lastEnterPictureBox.Name = "lastEnterPictureBox";
            lastEnterPictureBox.Size = new System.Drawing.Size(60, 60);
            lastEnterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            lastEnterPictureBox.TabIndex = 11;
            lastEnterPictureBox.TabStop = false;
            lastEnterPictureBox.Click += lastEnterPictureBox_Click;
            // 
            // productDataGridView
            // 
            productDataGridView.AllowUserToAddRows = false;
            productDataGridView.AllowUserToDeleteRows = false;
            productDataGridView.AllowUserToOrderColumns = true;
            productDataGridView.AllowUserToResizeColumns = false;
            productDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(204, 204, 204);
            productDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            productDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(86, 161, 191);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(250, 250, 250);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            productDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(104, 166, 250);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            productDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            productDataGridView.EnableHeadersVisualStyles = false;
            productDataGridView.Location = new System.Drawing.Point(113, 318);
            productDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            productDataGridView.Name = "productDataGridView";
            productDataGridView.ReadOnly = true;
            productDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            productDataGridView.RowHeadersWidth = 51;
            productDataGridView.RowTemplate.Height = 24;
            productDataGridView.Size = new System.Drawing.Size(401, 284);
            productDataGridView.TabIndex = 10;
            productDataGridView.CellContentClick += productDataGridView_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn1.HeaderText = "Ürün Adı";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn2.HeaderText = "Fiyat";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(9, 4);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(98, 142);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // orderDataGridView
            // 
            orderDataGridView.AllowUserToAddRows = false;
            orderDataGridView.AllowUserToDeleteRows = false;
            orderDataGridView.AllowUserToOrderColumns = true;
            orderDataGridView.AllowUserToResizeColumns = false;
            orderDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(204, 204, 204);
            orderDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            orderDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(86, 161, 191);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(250, 250, 250);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            orderDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ProductName, Amount, TotalPrice });
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(104, 166, 250);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            orderDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            orderDataGridView.EnableHeadersVisualStyles = false;
            orderDataGridView.Location = new System.Drawing.Point(586, 137);
            orderDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            orderDataGridView.Name = "orderDataGridView";
            orderDataGridView.ReadOnly = true;
            orderDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            orderDataGridView.RowHeadersWidth = 51;
            orderDataGridView.RowTemplate.Height = 24;
            orderDataGridView.Size = new System.Drawing.Size(522, 515);
            orderDataGridView.TabIndex = 4;
            // 
            // ProductName
            // 
            ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            ProductName.HeaderText = "Ürün Adı";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Width = 250;
            // 
            // Amount
            // 
            Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            Amount.HeaderText = "Miktar";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.Width = 125;
            // 
            // TotalPrice
            // 
            TotalPrice.HeaderText = "Fiyat";
            TotalPrice.MinimumWidth = 6;
            TotalPrice.Name = "TotalPrice";
            TotalPrice.ReadOnly = true;
            TotalPrice.Width = 125;
            // 
            // amountNumericUpDown
            // 
            amountNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            amountNumericUpDown.Location = new System.Drawing.Point(113, 677);
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
            enterPictureBox.Location = new System.Drawing.Point(258, 734);
            enterPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            enterPictureBox.Name = "enterPictureBox";
            enterPictureBox.Size = new System.Drawing.Size(60, 60);
            enterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            enterPictureBox.TabIndex = 4;
            enterPictureBox.TabStop = false;
            enterPictureBox.Click += enterPictureBox_Click;
            // 
            // menuComboBox
            // 
            menuComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            menuComboBox.FormattingEnabled = true;
            menuComboBox.Location = new System.Drawing.Point(113, 249);
            menuComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            menuComboBox.Name = "menuComboBox";
            menuComboBox.Size = new System.Drawing.Size(146, 31);
            menuComboBox.TabIndex = 3;
            menuComboBox.SelectedIndexChanged += menuComboBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(43, 679);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(64, 23);
            label4.TabIndex = 1;
            label4.Text = "Miktar";
            label4.Click += label3_Click;
            // 
            // fullTableComboBox
            // 
            fullTableComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            fullTableComboBox.FormattingEnabled = true;
            fullTableComboBox.Location = new System.Drawing.Point(113, 181);
            fullTableComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            fullTableComboBox.Name = "fullTableComboBox";
            fullTableComboBox.Size = new System.Drawing.Size(146, 31);
            fullTableComboBox.TabIndex = 3;
            fullTableComboBox.SelectedIndexChanged += fullTableComboBox_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(0, 632);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(110, 23);
            label7.TabIndex = 1;
            label7.Text = "Seçilen Ürün";
            label7.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(52, 318);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(49, 23);
            label5.TabIndex = 1;
            label5.Text = "Ürün";
            label5.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(52, 252);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(55, 23);
            label1.TabIndex = 1;
            label1.Text = "Menü";
            label1.Click += label3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(780, 110);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(154, 23);
            label6.TabIndex = 1;
            label6.Text = "Eklenecek Ürünler";
            label6.Click += label3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(56, 185);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(51, 23);
            label3.TabIndex = 1;
            label3.Text = "Masa";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(568, 16);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(86, 31);
            label2.TabIndex = 1;
            label2.Text = "Sipariş";
            // 
            // addExpensePanel
            // 
            addExpensePanel.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            addExpensePanel.Controls.Add(emptyTableComboBox);
            addExpensePanel.Controls.Add(label8);
            addExpensePanel.Controls.Add(enterTablePictureBox);
            addExpensePanel.Controls.Add(label12);
            addExpensePanel.Location = new System.Drawing.Point(1212, 36);
            addExpensePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            addExpensePanel.Name = "addExpensePanel";
            addExpensePanel.Size = new System.Drawing.Size(399, 275);
            addExpensePanel.TabIndex = 5;
            // 
            // emptyTableComboBox
            // 
            emptyTableComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            emptyTableComboBox.FormattingEnabled = true;
            emptyTableComboBox.Location = new System.Drawing.Point(133, 81);
            emptyTableComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            emptyTableComboBox.Name = "emptyTableComboBox";
            emptyTableComboBox.Size = new System.Drawing.Size(146, 31);
            emptyTableComboBox.TabIndex = 34;
            emptyTableComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(76, 85);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(51, 23);
            label8.TabIndex = 33;
            label8.Text = "Masa";
            // 
            // enterTablePictureBox
            // 
            enterTablePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            enterTablePictureBox.Image = (System.Drawing.Image)resources.GetObject("enterTablePictureBox.Image");
            enterTablePictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            enterTablePictureBox.Location = new System.Drawing.Point(176, 137);
            enterTablePictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            enterTablePictureBox.Name = "enterTablePictureBox";
            enterTablePictureBox.Size = new System.Drawing.Size(50, 50);
            enterTablePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            enterTablePictureBox.TabIndex = 32;
            enterTablePictureBox.TabStop = false;
            enterTablePictureBox.Click += enterTablePictureBox_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label12.ForeColor = System.Drawing.Color.White;
            label12.Location = new System.Drawing.Point(149, 16);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(103, 31);
            label12.TabIndex = 1;
            label12.Text = "Masa Aç";
            // 
            // NewOrder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(5, 41, 64);
            ClientSize = new System.Drawing.Size(1656, 1055);
            Controls.Add(addExpensePanel);
            Controls.Add(newOrderPanel);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "NewOrder";
            Text = "NewOrder";
            Load += NewOrder_Load;
            newOrderPanel.ResumeLayout(false);
            newOrderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)deletePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)lastEnterPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)productDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)amountNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)enterPictureBox).EndInit();
            addExpensePanel.ResumeLayout(false);
            addExpensePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)enterTablePictureBox).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private System.Windows.Forms.Panel newOrderPanel;
        private System.Windows.Forms.PictureBox enterPictureBox;
        private System.Windows.Forms.ComboBox menuComboBox;
        private System.Windows.Forms.ComboBox fullTableComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox lastEnterPictureBox;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox selectedProductTextBox;
        private System.Windows.Forms.PictureBox deletePictureBox;
        private System.Windows.Forms.Panel addExpensePanel;
        private System.Windows.Forms.PictureBox enterTablePictureBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox emptyTableComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
    }
}