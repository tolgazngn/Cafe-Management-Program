namespace CafeMax.Forms
{
    partial class UserProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfile));
            jobLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            enterPictureBox2 = new System.Windows.Forms.PictureBox();
            repeatPasswordTextBox = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            newPasswordTextBox = new System.Windows.Forms.TextBox();
            pictureBox5 = new System.Windows.Forms.PictureBox();
            label4 = new System.Windows.Forms.Label();
            currentPasswordTextBox = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            enterPictureBox3 = new System.Windows.Forms.PictureBox();
            emailTextBox = new System.Windows.Forms.TextBox();
            pictureBox6 = new System.Windows.Forms.PictureBox();
            label8 = new System.Windows.Forms.Label();
            phoneNumberTextBox = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)enterPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)enterPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // jobLabel
            // 
            jobLabel.AutoSize = true;
            jobLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            jobLabel.ForeColor = System.Drawing.Color.Silver;
            jobLabel.Location = new System.Drawing.Point(83, 53);
            jobLabel.Name = "jobLabel";
            jobLabel.Size = new System.Drawing.Size(57, 23);
            jobLabel.TabIndex = 11;
            jobLabel.Text = "Görev";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            fullNameLabel.ForeColor = System.Drawing.Color.White;
            fullNameLabel.Location = new System.Drawing.Point(83, 22);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(106, 28);
            fullNameLabel.TabIndex = 10;
            fullNameLabel.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            pictureBox1.Location = new System.Drawing.Point(12, 13);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(65, 65);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(255, 140, 66);
            panel1.Controls.Add(enterPictureBox2);
            panel1.Controls.Add(repeatPasswordTextBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(newPasswordTextBox);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(currentPasswordTextBox);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Location = new System.Drawing.Point(216, 137);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(332, 366);
            panel1.TabIndex = 12;
            // 
            // enterPictureBox2
            // 
            enterPictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            enterPictureBox2.Image = (System.Drawing.Image)resources.GetObject("enterPictureBox2.Image");
            enterPictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            enterPictureBox2.Location = new System.Drawing.Point(140, 274);
            enterPictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            enterPictureBox2.Name = "enterPictureBox2";
            enterPictureBox2.Size = new System.Drawing.Size(50, 50);
            enterPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            enterPictureBox2.TabIndex = 8;
            enterPictureBox2.TabStop = false;
            enterPictureBox2.Click += enterPictureBox2_Click;
            // 
            // repeatPasswordTextBox
            // 
            repeatPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            repeatPasswordTextBox.Location = new System.Drawing.Point(140, 222);
            repeatPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            repeatPasswordTextBox.MaxLength = 20;
            repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            repeatPasswordTextBox.PasswordChar = '●';
            repeatPasswordTextBox.Size = new System.Drawing.Size(146, 30);
            repeatPasswordTextBox.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(74, 225);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(60, 23);
            label6.TabIndex = 6;
            label6.Text = "Tekrar";
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            newPasswordTextBox.Location = new System.Drawing.Point(140, 155);
            newPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            newPasswordTextBox.MaxLength = 20;
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.PasswordChar = '●';
            newPasswordTextBox.Size = new System.Drawing.Size(146, 30);
            newPasswordTextBox.TabIndex = 3;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (System.Drawing.Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            pictureBox5.Location = new System.Drawing.Point(259, 9);
            pictureBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(70, 70);
            pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(92, 162);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(42, 23);
            label4.TabIndex = 6;
            label4.Text = "Yeni";
            // 
            // currentPasswordTextBox
            // 
            currentPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            currentPasswordTextBox.Location = new System.Drawing.Point(140, 105);
            currentPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            currentPasswordTextBox.MaxLength = 20;
            currentPasswordTextBox.Name = "currentPasswordTextBox";
            currentPasswordTextBox.PasswordChar = '●';
            currentPasswordTextBox.Size = new System.Drawing.Size(146, 30);
            currentPasswordTextBox.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label11.ForeColor = System.Drawing.Color.Gainsboro;
            label11.Location = new System.Drawing.Point(128, 189);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(158, 17);
            label11.TabIndex = 6;
            label11.Text = "(Maksimum 20 karakter)";
            label11.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(22, 108);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(112, 23);
            label1.TabIndex = 6;
            label1.Text = "Mevcut Şifre";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(10, 27);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(153, 31);
            label3.TabIndex = 1;
            label3.Text = "Şifreyi Yenile";
            label3.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(255, 140, 66);
            panel2.Controls.Add(enterPictureBox3);
            panel2.Controls.Add(emailTextBox);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(phoneNumberTextBox);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Location = new System.Drawing.Point(590, 137);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(426, 288);
            panel2.TabIndex = 12;
            // 
            // enterPictureBox3
            // 
            enterPictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            enterPictureBox3.Image = (System.Drawing.Image)resources.GetObject("enterPictureBox3.Image");
            enterPictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            enterPictureBox3.Location = new System.Drawing.Point(186, 202);
            enterPictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            enterPictureBox3.Name = "enterPictureBox3";
            enterPictureBox3.Size = new System.Drawing.Size(50, 50);
            enterPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            enterPictureBox3.TabIndex = 8;
            enterPictureBox3.TabStop = false;
            enterPictureBox3.Click += enterPictureBox3_Click;
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            emailTextBox.Location = new System.Drawing.Point(173, 151);
            emailTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new System.Drawing.Size(239, 30);
            emailTextBox.TabIndex = 6;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (System.Drawing.Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            pictureBox6.Location = new System.Drawing.Point(342, 9);
            pictureBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new System.Drawing.Size(70, 70);
            pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 9;
            pictureBox6.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(113, 158);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(54, 23);
            label8.TabIndex = 6;
            label8.Text = "Email";
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            phoneNumberTextBox.Location = new System.Drawing.Point(173, 99);
            phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new System.Drawing.Size(146, 30);
            phoneNumberTextBox.TabIndex = 5;
            phoneNumberTextBox.KeyPress += phoneNumberTextBox_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.Color.White;
            label9.Location = new System.Drawing.Point(18, 104);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(149, 23);
            label9.TabIndex = 6;
            label9.Text = "Telefon Numarası";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label10.ForeColor = System.Drawing.Color.White;
            label10.Location = new System.Drawing.Point(14, 27);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(305, 31);
            label10.TabIndex = 1;
            label10.Text = "İletişim Bilgilerini Güncelle\r\n";
            // 
            // UserProfile
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(5, 41, 64);
            ClientSize = new System.Drawing.Size(1218, 649);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(jobLabel);
            Controls.Add(fullNameLabel);
            Controls.Add(pictureBox1);
            Name = "UserProfile";
            Text = "CafeMax - Profil";
            FormClosing += UserProfile_FormClosing;
            FormClosed += UserProfile_FormClosed;
            Load += UserProfile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)enterPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)enterPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label jobLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox enterPictureBox2;
        private System.Windows.Forms.TextBox repeatPasswordTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox currentPasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox enterPictureBox3;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label11;
    }
}