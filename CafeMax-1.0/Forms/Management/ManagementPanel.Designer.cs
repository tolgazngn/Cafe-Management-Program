namespace CafeMax
{
    partial class ManagementPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementPanel));
            menuPanel = new System.Windows.Forms.Panel();
            jobLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            userOperationsButton = new System.Windows.Forms.Button();
            addExpenseButton = new System.Windows.Forms.Button();
            expensesButton = new System.Windows.Forms.Button();
            productOperationsButton = new System.Windows.Forms.Button();
            productInfosButton = new System.Windows.Forms.Button();
            employeeOperationsButton = new System.Windows.Forms.Button();
            employeeInfosButton = new System.Windows.Forms.Button();
            salesButton = new System.Windows.Forms.Button();
            ordersButton = new System.Windows.Forms.Button();
            tableInfosButton = new System.Windows.Forms.Button();
            titlePanel = new System.Windows.Forms.Panel();
            titleLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            mainPanel = new System.Windows.Forms.Panel();
            menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            titlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuPanel
            // 
            menuPanel.BackColor = System.Drawing.Color.FromArgb(5, 41, 64);
            menuPanel.Controls.Add(jobLabel);
            menuPanel.Controls.Add(fullNameLabel);
            menuPanel.Controls.Add(pictureBox1);
            menuPanel.Controls.Add(userOperationsButton);
            menuPanel.Controls.Add(addExpenseButton);
            menuPanel.Controls.Add(expensesButton);
            menuPanel.Controls.Add(productOperationsButton);
            menuPanel.Controls.Add(productInfosButton);
            menuPanel.Controls.Add(employeeOperationsButton);
            menuPanel.Controls.Add(employeeInfosButton);
            menuPanel.Controls.Add(salesButton);
            menuPanel.Controls.Add(ordersButton);
            menuPanel.Controls.Add(tableInfosButton);
            menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            menuPanel.Location = new System.Drawing.Point(0, 0);
            menuPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new System.Drawing.Size(228, 1055);
            menuPanel.TabIndex = 1;
            menuPanel.Paint += menuPanel_Paint;
            // 
            // jobLabel
            // 
            jobLabel.AutoSize = true;
            jobLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            jobLabel.ForeColor = System.Drawing.Color.Silver;
            jobLabel.Location = new System.Drawing.Point(83, 70);
            jobLabel.Name = "jobLabel";
            jobLabel.Size = new System.Drawing.Size(57, 23);
            jobLabel.TabIndex = 9;
            jobLabel.Text = "Görev";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            fullNameLabel.ForeColor = System.Drawing.Color.White;
            fullNameLabel.Location = new System.Drawing.Point(83, 39);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(106, 28);
            fullNameLabel.TabIndex = 10;
            fullNameLabel.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            pictureBox1.Location = new System.Drawing.Point(12, 29);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(65, 65);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // userOperationsButton
            // 
            userOperationsButton.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            userOperationsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            userOperationsButton.FlatAppearance.BorderSize = 0;
            userOperationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            userOperationsButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            userOperationsButton.ForeColor = System.Drawing.Color.White;
            userOperationsButton.Location = new System.Drawing.Point(0, 782);
            userOperationsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            userOperationsButton.Name = "userOperationsButton";
            userOperationsButton.Size = new System.Drawing.Size(228, 59);
            userOperationsButton.TabIndex = 6;
            userOperationsButton.Text = "Kullanıcı İşlemleri";
            userOperationsButton.UseVisualStyleBackColor = false;
            userOperationsButton.Click += userOperationsButton_Click;
            // 
            // addExpenseButton
            // 
            addExpenseButton.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            addExpenseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            addExpenseButton.FlatAppearance.BorderSize = 0;
            addExpenseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            addExpenseButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            addExpenseButton.ForeColor = System.Drawing.Color.White;
            addExpenseButton.Location = new System.Drawing.Point(0, 709);
            addExpenseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            addExpenseButton.Name = "addExpenseButton";
            addExpenseButton.Size = new System.Drawing.Size(228, 65);
            addExpenseButton.TabIndex = 6;
            addExpenseButton.Text = "Gider Ekle";
            addExpenseButton.UseVisualStyleBackColor = false;
            addExpenseButton.Click += addExpenseButton_Click;
            // 
            // expensesButton
            // 
            expensesButton.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            expensesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            expensesButton.FlatAppearance.BorderSize = 0;
            expensesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            expensesButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            expensesButton.ForeColor = System.Drawing.Color.White;
            expensesButton.Location = new System.Drawing.Point(0, 636);
            expensesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            expensesButton.Name = "expensesButton";
            expensesButton.Size = new System.Drawing.Size(228, 65);
            expensesButton.TabIndex = 6;
            expensesButton.Text = "Giderler";
            expensesButton.UseVisualStyleBackColor = false;
            expensesButton.Click += expensesButton_Click;
            // 
            // productOperationsButton
            // 
            productOperationsButton.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            productOperationsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            productOperationsButton.FlatAppearance.BorderSize = 0;
            productOperationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            productOperationsButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            productOperationsButton.ForeColor = System.Drawing.Color.White;
            productOperationsButton.Location = new System.Drawing.Point(0, 563);
            productOperationsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            productOperationsButton.Name = "productOperationsButton";
            productOperationsButton.Size = new System.Drawing.Size(228, 65);
            productOperationsButton.TabIndex = 6;
            productOperationsButton.Text = "Ürün İşlemleri";
            productOperationsButton.UseVisualStyleBackColor = false;
            productOperationsButton.Click += productOperationsButton_Click;
            // 
            // productInfosButton
            // 
            productInfosButton.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            productInfosButton.Cursor = System.Windows.Forms.Cursors.Hand;
            productInfosButton.FlatAppearance.BorderSize = 0;
            productInfosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            productInfosButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            productInfosButton.ForeColor = System.Drawing.Color.White;
            productInfosButton.Location = new System.Drawing.Point(0, 490);
            productInfosButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            productInfosButton.Name = "productInfosButton";
            productInfosButton.Size = new System.Drawing.Size(228, 65);
            productInfosButton.TabIndex = 6;
            productInfosButton.Text = "Ürün Bilgileri";
            productInfosButton.UseVisualStyleBackColor = false;
            productInfosButton.Click += productInfosButton_Click;
            // 
            // employeeOperationsButton
            // 
            employeeOperationsButton.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            employeeOperationsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            employeeOperationsButton.FlatAppearance.BorderSize = 0;
            employeeOperationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            employeeOperationsButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            employeeOperationsButton.ForeColor = System.Drawing.Color.White;
            employeeOperationsButton.Location = new System.Drawing.Point(0, 417);
            employeeOperationsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            employeeOperationsButton.Name = "employeeOperationsButton";
            employeeOperationsButton.Size = new System.Drawing.Size(228, 65);
            employeeOperationsButton.TabIndex = 6;
            employeeOperationsButton.Text = "Personel İşlemleri";
            employeeOperationsButton.UseVisualStyleBackColor = false;
            employeeOperationsButton.Click += employeeOperationsButton_Click;
            // 
            // employeeInfosButton
            // 
            employeeInfosButton.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            employeeInfosButton.Cursor = System.Windows.Forms.Cursors.Hand;
            employeeInfosButton.FlatAppearance.BorderSize = 0;
            employeeInfosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            employeeInfosButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            employeeInfosButton.ForeColor = System.Drawing.Color.White;
            employeeInfosButton.Location = new System.Drawing.Point(0, 344);
            employeeInfosButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            employeeInfosButton.Name = "employeeInfosButton";
            employeeInfosButton.Size = new System.Drawing.Size(228, 65);
            employeeInfosButton.TabIndex = 6;
            employeeInfosButton.Text = "Personel Bilgileri";
            employeeInfosButton.UseVisualStyleBackColor = false;
            employeeInfosButton.Click += employeeInfosButton_Click;
            // 
            // salesButton
            // 
            salesButton.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            salesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            salesButton.FlatAppearance.BorderSize = 0;
            salesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            salesButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            salesButton.ForeColor = System.Drawing.Color.White;
            salesButton.Location = new System.Drawing.Point(0, 271);
            salesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            salesButton.Name = "salesButton";
            salesButton.Size = new System.Drawing.Size(228, 65);
            salesButton.TabIndex = 6;
            salesButton.Text = "Satışlar";
            salesButton.UseVisualStyleBackColor = false;
            salesButton.Click += salesButton_Click;
            // 
            // ordersButton
            // 
            ordersButton.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            ordersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            ordersButton.FlatAppearance.BorderSize = 0;
            ordersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ordersButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            // tableInfosButton
            // 
            tableInfosButton.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            tableInfosButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            tableInfosButton.Cursor = System.Windows.Forms.Cursors.Hand;
            tableInfosButton.FlatAppearance.BorderSize = 0;
            tableInfosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            tableInfosButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tableInfosButton.ForeColor = System.Drawing.Color.White;
            tableInfosButton.Location = new System.Drawing.Point(0, 125);
            tableInfosButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableInfosButton.Name = "tableInfosButton";
            tableInfosButton.Size = new System.Drawing.Size(228, 65);
            tableInfosButton.TabIndex = 6;
            tableInfosButton.Text = "Masa Bilgileri";
            tableInfosButton.UseVisualStyleBackColor = false;
            tableInfosButton.Click += tableInfosButton_Click;
            // 
            // titlePanel
            // 
            titlePanel.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            titlePanel.Controls.Add(titleLabel);
            titlePanel.Controls.Add(label1);
            titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            titlePanel.Location = new System.Drawing.Point(228, 0);
            titlePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new System.Drawing.Size(1674, 125);
            titlePanel.TabIndex = 2;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Segoe UI", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            titleLabel.ForeColor = System.Drawing.Color.White;
            titleLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            titleLabel.Location = new System.Drawing.Point(6, 47);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(165, 46);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "Anasayfa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label1.Location = new System.Drawing.Point(697, 47);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(258, 46);
            label1.TabIndex = 4;
            label1.Text = "Yönetim Paneli";
            // 
            // mainPanel
            // 
            mainPanel.BackColor = System.Drawing.Color.FromArgb(5, 41, 64);
            mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(228, 125);
            mainPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new System.Drawing.Size(1674, 930);
            mainPanel.TabIndex = 3;
            // 
            // ManagementPanel
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(0, 31, 63);
            ClientSize = new System.Drawing.Size(1902, 1055);
            Controls.Add(mainPanel);
            Controls.Add(titlePanel);
            Controls.Add(menuPanel);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "ManagementPanel";
            Text = "CafeMax - Yönetim Paneli";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            FormClosing += ManagementPanel_FormClosing;
            Load += ManagementPanel_Load;
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            titlePanel.ResumeLayout(false);
            titlePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button productInfosButton;
        private System.Windows.Forms.Button employeeOperationsButton;
        private System.Windows.Forms.Button employeeInfosButton;
        private System.Windows.Forms.Button salesButton;
        private System.Windows.Forms.Button ordersButton;
        private System.Windows.Forms.Button tableInfosButton;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button userOperationsButton;
        private System.Windows.Forms.Button productOperationsButton;
        private System.Windows.Forms.Button addExpenseButton;
        private System.Windows.Forms.Button expensesButton;
        private System.Windows.Forms.Label jobLabel;
        private System.Windows.Forms.Label fullNameLabel;
    }
}