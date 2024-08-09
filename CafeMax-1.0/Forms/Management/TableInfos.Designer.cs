namespace CafeMax.Forms.Management
{
    partial class TableInfos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableInfos));
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            tableDataGridView = new System.Windows.Forms.DataGridView();
            TableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Is_Busy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            addTablePanel = new System.Windows.Forms.Panel();
            enter = new System.Windows.Forms.PictureBox();
            nameTextBox = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            enter2 = new System.Windows.Forms.PictureBox();
            selectedTableNameTextBox = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableDataGridView).BeginInit();
            addTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)enter).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)enter2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tableDataGridView);
            panel1.Location = new System.Drawing.Point(113, 128);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(512, 552);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(200, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(120, 38);
            label1.TabIndex = 1;
            label1.Text = "Masalar";
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
            tableDataGridView.CellContentClick += tableDataGridView_CellContentClick;
            // 
            // TableName
            // 
            TableName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            TableName.HeaderText = "Masa Adı";
            TableName.MinimumWidth = 6;
            TableName.Name = "TableName";
            TableName.ReadOnly = true;
            TableName.Width = 220;
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
            // addTablePanel
            // 
            addTablePanel.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            addTablePanel.Controls.Add(enter);
            addTablePanel.Controls.Add(nameTextBox);
            addTablePanel.Controls.Add(label6);
            addTablePanel.Controls.Add(label2);
            addTablePanel.Location = new System.Drawing.Point(701, 128);
            addTablePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            addTablePanel.Name = "addTablePanel";
            addTablePanel.Size = new System.Drawing.Size(406, 265);
            addTablePanel.TabIndex = 5;
            // 
            // enter
            // 
            enter.Cursor = System.Windows.Forms.Cursors.Hand;
            enter.Image = (System.Drawing.Image)resources.GetObject("enter.Image");
            enter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            enter.Location = new System.Drawing.Point(164, 165);
            enter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            enter.Name = "enter";
            enter.Size = new System.Drawing.Size(60, 60);
            enter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            enter.TabIndex = 32;
            enter.TabStop = false;
            enter.Click += enter_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            nameTextBox.Location = new System.Drawing.Point(133, 84);
            nameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            nameTextBox.MaxLength = 20;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new System.Drawing.Size(161, 30);
            nameTextBox.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(45, 88);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(84, 23);
            label6.TabIndex = 28;
            label6.Text = "Masa Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(121, 12);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(148, 38);
            label2.TabIndex = 1;
            label2.Text = "Masa Ekle";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(255, 51, 51);
            panel2.Controls.Add(enter2);
            panel2.Controls.Add(selectedTableNameTextBox);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Location = new System.Drawing.Point(1162, 128);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(406, 265);
            panel2.TabIndex = 5;
            // 
            // enter2
            // 
            enter2.Cursor = System.Windows.Forms.Cursors.Hand;
            enter2.Image = (System.Drawing.Image)resources.GetObject("enter2.Image");
            enter2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            enter2.Location = new System.Drawing.Point(164, 165);
            enter2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            enter2.Name = "enter2";
            enter2.Size = new System.Drawing.Size(60, 60);
            enter2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            enter2.TabIndex = 32;
            enter2.TabStop = false;
            enter2.Click += enter2_Click;
            // 
            // selectedTableNameTextBox
            // 
            selectedTableNameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            selectedTableNameTextBox.Location = new System.Drawing.Point(153, 84);
            selectedTableNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            selectedTableNameTextBox.Name = "selectedTableNameTextBox";
            selectedTableNameTextBox.ReadOnly = true;
            selectedTableNameTextBox.Size = new System.Drawing.Size(161, 30);
            selectedTableNameTextBox.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(49, 88);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(98, 23);
            label3.TabIndex = 28;
            label3.Text = "Seçili Masa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(121, 12);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(171, 38);
            label4.TabIndex = 1;
            label4.Text = "Masa Kaldır";
            // 
            // TableInfos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(5, 41, 64);
            ClientSize = new System.Drawing.Size(1656, 1055);
            Controls.Add(panel2);
            Controls.Add(addTablePanel);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "TableInfos";
            Text = "TableInfos";
            Load += TableInfos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tableDataGridView).EndInit();
            addTablePanel.ResumeLayout(false);
            addTablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)enter).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)enter2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tableDataGridView;
        private System.Windows.Forms.Panel addTablePanel;
        private System.Windows.Forms.PictureBox enter;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox enter2;
        private System.Windows.Forms.TextBox selectedTableNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Is_Busy;
    }
}