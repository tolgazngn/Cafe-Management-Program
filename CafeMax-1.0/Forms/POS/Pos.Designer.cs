namespace CafeMax
{
    partial class Pos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pos));
            menuPanel = new System.Windows.Forms.Panel();
            jobLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            stockTrackingButton = new System.Windows.Forms.Button();
            salesButton = new System.Windows.Forms.Button();
            getPaidButton = new System.Windows.Forms.Button();
            newOrderButton = new System.Windows.Forms.Button();
            ordersButton = new System.Windows.Forms.Button();
            tableOperationsButton = new System.Windows.Forms.Button();
            titlePanel = new System.Windows.Forms.Panel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            titleLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            mainPanel = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            zReportButton = new System.Windows.Forms.Button();
            menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuPanel
            // 
            menuPanel.BackColor = System.Drawing.Color.FromArgb(5, 41, 64);
            menuPanel.Controls.Add(zReportButton);
            menuPanel.Controls.Add(jobLabel);
            menuPanel.Controls.Add(fullNameLabel);
            menuPanel.Controls.Add(pictureBox1);
            menuPanel.Controls.Add(stockTrackingButton);
            menuPanel.Controls.Add(salesButton);
            menuPanel.Controls.Add(getPaidButton);
            menuPanel.Controls.Add(newOrderButton);
            menuPanel.Controls.Add(ordersButton);
            menuPanel.Controls.Add(tableOperationsButton);
            menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            menuPanel.Location = new System.Drawing.Point(0, 0);
            menuPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new System.Drawing.Size(228, 1055);
            menuPanel.TabIndex = 0;
            menuPanel.Paint += menuPanel_Paint;
            // 
            // jobLabel
            // 
            jobLabel.AutoSize = true;
            jobLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            jobLabel.ForeColor = System.Drawing.Color.Silver;
            jobLabel.Location = new System.Drawing.Point(74, 69);
            jobLabel.Name = "jobLabel";
            jobLabel.Size = new System.Drawing.Size(57, 23);
            jobLabel.TabIndex = 8;
            jobLabel.Text = "Görev";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            fullNameLabel.ForeColor = System.Drawing.Color.White;
            fullNameLabel.Location = new System.Drawing.Point(74, 38);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(106, 28);
            fullNameLabel.TabIndex = 8;
            fullNameLabel.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            pictureBox1.Location = new System.Drawing.Point(3, 29);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(65, 65);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // stockTrackingButton
            // 
            stockTrackingButton.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            stockTrackingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            stockTrackingButton.FlatAppearance.BorderSize = 0;
            stockTrackingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            stockTrackingButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            stockTrackingButton.ForeColor = System.Drawing.Color.White;
            stockTrackingButton.Location = new System.Drawing.Point(0, 490);
            stockTrackingButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            stockTrackingButton.Name = "stockTrackingButton";
            stockTrackingButton.Size = new System.Drawing.Size(228, 65);
            stockTrackingButton.TabIndex = 6;
            stockTrackingButton.Text = "Stok Takip";
            stockTrackingButton.UseVisualStyleBackColor = false;
            stockTrackingButton.Click += stockTrackingButton_Click;
            // 
            // salesButton
            // 
            salesButton.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            salesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            salesButton.FlatAppearance.BorderSize = 0;
            salesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            salesButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            salesButton.ForeColor = System.Drawing.Color.White;
            salesButton.Location = new System.Drawing.Point(0, 417);
            salesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            salesButton.Name = "salesButton";
            salesButton.Size = new System.Drawing.Size(228, 65);
            salesButton.TabIndex = 6;
            salesButton.Text = "Satışlar";
            salesButton.UseVisualStyleBackColor = false;
            salesButton.Click += salesButton_Click;
            // 
            // getPaidButton
            // 
            getPaidButton.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            getPaidButton.Cursor = System.Windows.Forms.Cursors.Hand;
            getPaidButton.FlatAppearance.BorderSize = 0;
            getPaidButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            getPaidButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            getPaidButton.ForeColor = System.Drawing.Color.White;
            getPaidButton.Location = new System.Drawing.Point(0, 344);
            getPaidButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            getPaidButton.Name = "getPaidButton";
            getPaidButton.Size = new System.Drawing.Size(228, 65);
            getPaidButton.TabIndex = 6;
            getPaidButton.Text = "Ödeme Al";
            getPaidButton.UseVisualStyleBackColor = false;
            getPaidButton.Click += getPaidButton_Click;
            // 
            // newOrderButton
            // 
            newOrderButton.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            newOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            newOrderButton.FlatAppearance.BorderSize = 0;
            newOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            newOrderButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            newOrderButton.ForeColor = System.Drawing.Color.White;
            newOrderButton.Location = new System.Drawing.Point(0, 271);
            newOrderButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            newOrderButton.Name = "newOrderButton";
            newOrderButton.Size = new System.Drawing.Size(228, 65);
            newOrderButton.TabIndex = 6;
            newOrderButton.Text = "Yeni Sipariş";
            newOrderButton.UseVisualStyleBackColor = false;
            newOrderButton.Click += newOrderButton_Click;
            // 
            // ordersButton
            // 
            ordersButton.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            ordersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            ordersButton.FlatAppearance.BorderSize = 0;
            ordersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ordersButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ordersButton.ForeColor = System.Drawing.Color.White;
            ordersButton.Location = new System.Drawing.Point(0, 198);
            ordersButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ordersButton.Name = "ordersButton";
            ordersButton.Size = new System.Drawing.Size(228, 65);
            ordersButton.TabIndex = 6;
            ordersButton.Text = "Siparişler";
            ordersButton.UseVisualStyleBackColor = false;
            ordersButton.Click += ordersButton_Click;
            // 
            // tableOperationsButton
            // 
            tableOperationsButton.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            tableOperationsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            tableOperationsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            tableOperationsButton.FlatAppearance.BorderSize = 0;
            tableOperationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            tableOperationsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tableOperationsButton.ForeColor = System.Drawing.Color.White;
            tableOperationsButton.Location = new System.Drawing.Point(0, 125);
            tableOperationsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableOperationsButton.Name = "tableOperationsButton";
            tableOperationsButton.Size = new System.Drawing.Size(228, 65);
            tableOperationsButton.TabIndex = 6;
            tableOperationsButton.Text = "Masa İşlemleri";
            tableOperationsButton.UseVisualStyleBackColor = false;
            tableOperationsButton.Click += tableOperationsButton_Click;
            // 
            // titlePanel
            // 
            titlePanel.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            titlePanel.Controls.Add(pictureBox2);
            titlePanel.Controls.Add(titleLabel);
            titlePanel.Controls.Add(label1);
            titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            titlePanel.Location = new System.Drawing.Point(228, 0);
            titlePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new System.Drawing.Size(1674, 125);
            titlePanel.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            pictureBox2.Location = new System.Drawing.Point(1579, 38);
            pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(60, 60);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Segoe UI", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            titleLabel.ForeColor = System.Drawing.Color.White;
            titleLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            titleLabel.Location = new System.Drawing.Point(6, 38);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(165, 46);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "Anasayfa";
            titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label1.Location = new System.Drawing.Point(773, 38);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(86, 46);
            label1.TabIndex = 4;
            label1.Text = "POS";
            // 
            // mainPanel
            // 
            mainPanel.BackColor = System.Drawing.Color.FromArgb(5, 41, 64);
            mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            mainPanel.Controls.Add(label2);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(228, 125);
            mainPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new System.Drawing.Size(1674, 930);
            mainPanel.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label2.Location = new System.Drawing.Point(688, 365);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(0, 38);
            label2.TabIndex = 4;
            // 
            // zReportButton
            // 
            zReportButton.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            zReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            zReportButton.FlatAppearance.BorderSize = 0;
            zReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            zReportButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            zReportButton.ForeColor = System.Drawing.Color.White;
            zReportButton.Location = new System.Drawing.Point(0, 563);
            zReportButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            zReportButton.Name = "zReportButton";
            zReportButton.Size = new System.Drawing.Size(228, 65);
            zReportButton.TabIndex = 9;
            zReportButton.Text = "Z Raporu\r\n(Gün Sonu)";
            zReportButton.UseVisualStyleBackColor = false;
            zReportButton.Click += zReportButton_Click;
            // 
            // Pos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(0, 31, 63);
            ClientSize = new System.Drawing.Size(1902, 1055);
            Controls.Add(mainPanel);
            Controls.Add(titlePanel);
            Controls.Add(menuPanel);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Pos";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "CafeMax - POS";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            FormClosing += Pos_FormClosing;
            Load += Pos_Load;
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            titlePanel.ResumeLayout(false);
            titlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button tableOperationsButton;
        private System.Windows.Forms.Button stockTrackingButton;
        private System.Windows.Forms.Button salesButton;
        private System.Windows.Forms.Button getPaidButton;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Button ordersButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label jobLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button zReportButton;
    }
}