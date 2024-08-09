namespace CafeMax.Forms.Management
{
    partial class Expenses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expenses));
            label1 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            secondDateTimePicker = new System.Windows.Forms.DateTimePicker();
            firstDateTimePicker = new System.Windows.Forms.DateTimePicker();
            expensesPanel = new System.Windows.Forms.Panel();
            expensesDataGridView = new System.Windows.Forms.DataGridView();
            allRowsCheckBox = new System.Windows.Forms.CheckBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            searchButton = new System.Windows.Forms.PictureBox();
            Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            expensesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)expensesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchButton).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(714, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(122, 38);
            label1.TabIndex = 1;
            label1.Text = "Giderler";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(471, 140);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(45, 23);
            label5.TabIndex = 29;
            label5.Text = "Bitiş";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(66, 140);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(85, 23);
            label4.TabIndex = 30;
            label4.Text = "Başlangıç";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(65, 89);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 28);
            label3.TabIndex = 31;
            label3.Text = "Tarih";
            // 
            // secondDateTimePicker
            // 
            secondDateTimePicker.Location = new System.Drawing.Point(522, 140);
            secondDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            secondDateTimePicker.Name = "secondDateTimePicker";
            secondDateTimePicker.Size = new System.Drawing.Size(284, 27);
            secondDateTimePicker.TabIndex = 27;
            // 
            // firstDateTimePicker
            // 
            firstDateTimePicker.Location = new System.Drawing.Point(157, 140);
            firstDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            firstDateTimePicker.Name = "firstDateTimePicker";
            firstDateTimePicker.Size = new System.Drawing.Size(284, 27);
            firstDateTimePicker.TabIndex = 28;
            // 
            // expensesPanel
            // 
            expensesPanel.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            expensesPanel.Controls.Add(label1);
            expensesPanel.Controls.Add(expensesDataGridView);
            expensesPanel.Location = new System.Drawing.Point(70, 208);
            expensesPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            expensesPanel.Name = "expensesPanel";
            expensesPanel.Size = new System.Drawing.Size(1518, 552);
            expensesPanel.TabIndex = 26;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(86, 161, 191);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(250, 250, 250);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            expensesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            expensesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            expensesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Type, Amount, Description, Paid, PaymentMethod, CreatedBy, Date });
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(104, 166, 250);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            expensesDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            expensesDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            expensesDataGridView.EnableHeadersVisualStyles = false;
            expensesDataGridView.Location = new System.Drawing.Point(0, 60);
            expensesDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            expensesDataGridView.Name = "expensesDataGridView";
            expensesDataGridView.ReadOnly = true;
            expensesDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            expensesDataGridView.RowHeadersWidth = 51;
            expensesDataGridView.RowTemplate.Height = 24;
            expensesDataGridView.Size = new System.Drawing.Size(1518, 492);
            expensesDataGridView.TabIndex = 0;
            // 
            // allRowsCheckBox
            // 
            allRowsCheckBox.AutoSize = true;
            allRowsCheckBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            allRowsCheckBox.ForeColor = System.Drawing.Color.White;
            allRowsCheckBox.Location = new System.Drawing.Point(836, 140);
            allRowsCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            allRowsCheckBox.Name = "allRowsCheckBox";
            allRowsCheckBox.Size = new System.Drawing.Size(134, 27);
            allRowsCheckBox.TabIndex = 33;
            allRowsCheckBox.Text = "Tüm Kayıtlar";
            allRowsCheckBox.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(943, 1342);
            pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(35, 44);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // searchButton
            // 
            searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            searchButton.Image = (System.Drawing.Image)resources.GetObject("searchButton.Image");
            searchButton.Location = new System.Drawing.Point(994, 123);
            searchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            searchButton.Name = "searchButton";
            searchButton.Size = new System.Drawing.Size(64, 44);
            searchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            searchButton.TabIndex = 35;
            searchButton.TabStop = false;
            searchButton.Click += searchButton_Click;
            // 
            // Type
            // 
            Type.HeaderText = "Gider Tipi";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.ReadOnly = true;
            Type.Width = 250;
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
            Description.HeaderText = "Açıklama";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.Width = 400;
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
            PaymentMethod.Width = 150;
            // 
            // CreatedBy
            // 
            CreatedBy.HeaderText = "İşlemi Yapan";
            CreatedBy.MinimumWidth = 6;
            CreatedBy.Name = "CreatedBy";
            CreatedBy.ReadOnly = true;
            CreatedBy.Width = 200;
            // 
            // Date
            // 
            Date.HeaderText = "Tarih/Saat";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 220;
            // 
            // Expenses
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(5, 41, 64);
            ClientSize = new System.Drawing.Size(1656, 1055);
            Controls.Add(searchButton);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(secondDateTimePicker);
            Controls.Add(firstDateTimePicker);
            Controls.Add(expensesPanel);
            Controls.Add(allRowsCheckBox);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Expenses";
            Text = "Expenses";
            Load += Expenses_Load;
            expensesPanel.ResumeLayout(false);
            expensesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)expensesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker secondDateTimePicker;
        private System.Windows.Forms.DateTimePicker firstDateTimePicker;
        private System.Windows.Forms.Panel expensesPanel;
        private System.Windows.Forms.DataGridView expensesDataGridView;
        private System.Windows.Forms.CheckBox allRowsCheckBox;
        private System.Windows.Forms.PictureBox searchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}