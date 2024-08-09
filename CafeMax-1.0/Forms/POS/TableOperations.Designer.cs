namespace CafeMax
{
    partial class TableOperations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableOperations));
            tableDataGridView = new System.Windows.Forms.DataGridView();
            TableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Is_Busy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tablePanel = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            addExpensePanel = new System.Windows.Forms.Panel();
            fullTableComboBox = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            emptyTableComboBox = new System.Windows.Forms.ComboBox();
            label8 = new System.Windows.Forms.Label();
            enterTablePictureBox = new System.Windows.Forms.PictureBox();
            label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)tableDataGridView).BeginInit();
            tablePanel.SuspendLayout();
            addExpensePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)enterTablePictureBox).BeginInit();
            SuspendLayout();
            // 
            // tableDataGridView
            // 
            tableDataGridView.AllowUserToAddRows = false;
            tableDataGridView.AllowUserToDeleteRows = false;
            tableDataGridView.AllowUserToOrderColumns = true;
            tableDataGridView.AllowUserToResizeColumns = false;
            tableDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(204, 204, 204);
            tableDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tableDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(86, 161, 191);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(250, 250, 250);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            tableDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { TableName, Is_Busy });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(104, 166, 250);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            tableDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            tableDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            tableDataGridView.EnableHeadersVisualStyles = false;
            tableDataGridView.Location = new System.Drawing.Point(0, 60);
            tableDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableDataGridView.Name = "tableDataGridView";
            tableDataGridView.ReadOnly = true;
            tableDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            tableDataGridView.RowHeadersWidth = 51;
            tableDataGridView.RowTemplate.Height = 24;
            tableDataGridView.Size = new System.Drawing.Size(512, 492);
            tableDataGridView.TabIndex = 0;
            // 
            // TableName
            // 
            TableName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            TableName.HeaderText = "Masa Adı";
            TableName.MinimumWidth = 6;
            TableName.Name = "TableName";
            TableName.ReadOnly = true;
            TableName.Width = 250;
            // 
            // Is_Busy
            // 
            Is_Busy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            Is_Busy.HeaderText = "Durum";
            Is_Busy.MinimumWidth = 6;
            Is_Busy.Name = "Is_Busy";
            Is_Busy.ReadOnly = true;
            Is_Busy.Width = 300;
            // 
            // tablePanel
            // 
            tablePanel.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            tablePanel.Controls.Add(label1);
            tablePanel.Controls.Add(tableDataGridView);
            tablePanel.Location = new System.Drawing.Point(112, 141);
            tablePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tablePanel.Name = "tablePanel";
            tablePanel.Size = new System.Drawing.Size(512, 552);
            tablePanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(200, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(98, 31);
            label1.TabIndex = 1;
            label1.Text = "Masalar";
            // 
            // addExpensePanel
            // 
            addExpensePanel.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            addExpensePanel.Controls.Add(fullTableComboBox);
            addExpensePanel.Controls.Add(label2);
            addExpensePanel.Controls.Add(emptyTableComboBox);
            addExpensePanel.Controls.Add(label8);
            addExpensePanel.Controls.Add(enterTablePictureBox);
            addExpensePanel.Controls.Add(label12);
            addExpensePanel.Location = new System.Drawing.Point(739, 141);
            addExpensePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            addExpensePanel.Name = "addExpensePanel";
            addExpensePanel.Size = new System.Drawing.Size(399, 275);
            addExpensePanel.TabIndex = 6;
            // 
            // fullTableComboBox
            // 
            fullTableComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            fullTableComboBox.FormattingEnabled = true;
            fullTableComboBox.Location = new System.Drawing.Point(159, 84);
            fullTableComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            fullTableComboBox.Name = "fullTableComboBox";
            fullTableComboBox.Size = new System.Drawing.Size(146, 31);
            fullTableComboBox.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(21, 140);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(132, 23);
            label2.TabIndex = 35;
            label2.Text = "Taşınacak Masa";
            // 
            // emptyTableComboBox
            // 
            emptyTableComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            emptyTableComboBox.FormattingEnabled = true;
            emptyTableComboBox.Location = new System.Drawing.Point(159, 137);
            emptyTableComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            emptyTableComboBox.Name = "emptyTableComboBox";
            emptyTableComboBox.Size = new System.Drawing.Size(146, 31);
            emptyTableComboBox.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(102, 87);
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
            enterTablePictureBox.Location = new System.Drawing.Point(173, 202);
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
            label12.Location = new System.Drawing.Point(130, 15);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(149, 31);
            label12.TabIndex = 1;
            label12.Text = "Masa Taşıma";
            // 
            // TableOperations
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(5, 41, 64);
            ClientSize = new System.Drawing.Size(1656, 1055);
            Controls.Add(addExpensePanel);
            Controls.Add(tablePanel);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "TableOperations";
            Text = "TableOperations";
            Load += TableOperations_Load;
            ((System.ComponentModel.ISupportInitialize)tableDataGridView).EndInit();
            tablePanel.ResumeLayout(false);
            tablePanel.PerformLayout();
            addExpensePanel.ResumeLayout(false);
            addExpensePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)enterTablePictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView tableDataGridView;
        private System.Windows.Forms.Panel tablePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel addExpensePanel;
        private System.Windows.Forms.ComboBox emptyTableComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox enterTablePictureBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox fullTableComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Is_Busy;
    }
}