namespace CafeMax.Forms.Management
{
    partial class ProductOperations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductOperations));
            addProductPanel = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            enter = new System.Windows.Forms.PictureBox();
            menuComboBox = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            unitPriceTextBox = new System.Windows.Forms.TextBox();
            label = new System.Windows.Forms.Label();
            nameTextBox = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            updateUnitPricePanel = new System.Windows.Forms.Panel();
            menusComboBox = new System.Windows.Forms.ComboBox();
            label7 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            enterUpdateUnitPrice = new System.Windows.Forms.PictureBox();
            productComboBox = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            newPriceTextBox = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            addProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enter).BeginInit();
            updateUnitPricePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)enterUpdateUnitPrice).BeginInit();
            SuspendLayout();
            // 
            // addProductPanel
            // 
            addProductPanel.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            addProductPanel.Controls.Add(pictureBox1);
            addProductPanel.Controls.Add(enter);
            addProductPanel.Controls.Add(menuComboBox);
            addProductPanel.Controls.Add(label4);
            addProductPanel.Controls.Add(unitPriceTextBox);
            addProductPanel.Controls.Add(label);
            addProductPanel.Controls.Add(nameTextBox);
            addProductPanel.Controls.Add(label6);
            addProductPanel.Controls.Add(label1);
            addProductPanel.Location = new System.Drawing.Point(78, 166);
            addProductPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            addProductPanel.Name = "addProductPanel";
            addProductPanel.Size = new System.Drawing.Size(619, 404);
            addProductPanel.TabIndex = 4;
            addProductPanel.Paint += addProductPanel_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            pictureBox1.Location = new System.Drawing.Point(424, 21);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(180, 225);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // enter
            // 
            enter.Cursor = System.Windows.Forms.Cursors.Hand;
            enter.Image = (System.Drawing.Image)resources.GetObject("enter.Image");
            enter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            enter.Location = new System.Drawing.Point(263, 305);
            enter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            enter.Name = "enter";
            enter.Size = new System.Drawing.Size(60, 60);
            enter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            enter.TabIndex = 32;
            enter.TabStop = false;
            enter.Click += enter_Click;
            // 
            // menuComboBox
            // 
            menuComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            menuComboBox.FormattingEnabled = true;
            menuComboBox.Location = new System.Drawing.Point(133, 218);
            menuComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            menuComboBox.Name = "menuComboBox";
            menuComboBox.Size = new System.Drawing.Size(161, 31);
            menuComboBox.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(72, 221);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(55, 23);
            label4.TabIndex = 28;
            label4.Text = "Menü";
            // 
            // unitPriceTextBox
            // 
            unitPriceTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            unitPriceTextBox.Location = new System.Drawing.Point(133, 150);
            unitPriceTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            unitPriceTextBox.Name = "unitPriceTextBox";
            unitPriceTextBox.Size = new System.Drawing.Size(161, 30);
            unitPriceTextBox.TabIndex = 29;
            unitPriceTextBox.KeyPress += unitPriceTextBox_KeyPress;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label.ForeColor = System.Drawing.Color.White;
            label.Location = new System.Drawing.Point(29, 154);
            label.Name = "label";
            label.Size = new System.Drawing.Size(98, 23);
            label.TabIndex = 28;
            label.Text = "Birim Fiyat";
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            nameTextBox.Location = new System.Drawing.Point(133, 84);
            nameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new System.Drawing.Size(161, 30);
            nameTextBox.TabIndex = 29;
            nameTextBox.KeyPress += nameTextBox_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(45, 88);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(82, 23);
            label6.TabIndex = 28;
            label6.Text = "Ürün Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(219, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(144, 38);
            label1.TabIndex = 1;
            label1.Text = "Ürün Ekle";
            // 
            // updateUnitPricePanel
            // 
            updateUnitPricePanel.BackColor = System.Drawing.Color.FromArgb(27, 97, 140);
            updateUnitPricePanel.Controls.Add(menusComboBox);
            updateUnitPricePanel.Controls.Add(label7);
            updateUnitPricePanel.Controls.Add(label2);
            updateUnitPricePanel.Controls.Add(enterUpdateUnitPrice);
            updateUnitPricePanel.Controls.Add(productComboBox);
            updateUnitPricePanel.Controls.Add(label3);
            updateUnitPricePanel.Controls.Add(newPriceTextBox);
            updateUnitPricePanel.Controls.Add(label5);
            updateUnitPricePanel.Location = new System.Drawing.Point(770, 166);
            updateUnitPricePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            updateUnitPricePanel.Name = "updateUnitPricePanel";
            updateUnitPricePanel.Size = new System.Drawing.Size(348, 404);
            updateUnitPricePanel.TabIndex = 5;
            // 
            // menusComboBox
            // 
            menusComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            menusComboBox.FormattingEnabled = true;
            menusComboBox.Location = new System.Drawing.Point(140, 74);
            menusComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            menusComboBox.Name = "menusComboBox";
            menusComboBox.Size = new System.Drawing.Size(146, 31);
            menusComboBox.TabIndex = 9;
            menusComboBox.SelectedIndexChanged += menusComboBox_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(79, 77);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(55, 23);
            label7.TabIndex = 10;
            label7.Text = "Menü";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(37, 11);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(281, 38);
            label2.TabIndex = 1;
            label2.Text = "Birim Fiyat Güncelle";
            // 
            // enterUpdateUnitPrice
            // 
            enterUpdateUnitPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            enterUpdateUnitPrice.Image = (System.Drawing.Image)resources.GetObject("enterUpdateUnitPrice.Image");
            enterUpdateUnitPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            enterUpdateUnitPrice.Location = new System.Drawing.Point(151, 305);
            enterUpdateUnitPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            enterUpdateUnitPrice.Name = "enterUpdateUnitPrice";
            enterUpdateUnitPrice.Size = new System.Drawing.Size(60, 60);
            enterUpdateUnitPrice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            enterUpdateUnitPrice.TabIndex = 32;
            enterUpdateUnitPrice.TabStop = false;
            enterUpdateUnitPrice.Click += enterUpdateUnitPrice_Click;
            // 
            // productComboBox
            // 
            productComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            productComboBox.FormattingEnabled = true;
            productComboBox.Location = new System.Drawing.Point(140, 136);
            productComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            productComboBox.Name = "productComboBox";
            productComboBox.Size = new System.Drawing.Size(161, 31);
            productComboBox.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(83, 139);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(49, 23);
            label3.TabIndex = 28;
            label3.Text = "Ürün";
            // 
            // newPriceTextBox
            // 
            newPriceTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            newPriceTextBox.Location = new System.Drawing.Point(140, 205);
            newPriceTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            newPriceTextBox.Name = "newPriceTextBox";
            newPriceTextBox.Size = new System.Drawing.Size(161, 30);
            newPriceTextBox.TabIndex = 29;
            newPriceTextBox.KeyPress += newPriceTextBox_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(46, 209);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(86, 23);
            label5.TabIndex = 28;
            label5.Text = "Yeni Fiyat";
            // 
            // ProductOperations
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(0, 31, 63);
            ClientSize = new System.Drawing.Size(1656, 1055);
            Controls.Add(updateUnitPricePanel);
            Controls.Add(addProductPanel);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "ProductOperations";
            Text = "ProductOperations";
            Load += ProductOperations_Load;
            addProductPanel.ResumeLayout(false);
            addProductPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)enter).EndInit();
            updateUnitPricePanel.ResumeLayout(false);
            updateUnitPricePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)enterUpdateUnitPrice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel addProductPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox enter;
        private System.Windows.Forms.ComboBox menuComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel updateUnitPricePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox enterUpdateUnitPrice;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newPriceTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox menusComboBox;
        private System.Windows.Forms.Label label7;
    }
}