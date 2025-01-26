namespace OnlineShoppingApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            txtSearch = new TextBox();
            cmbCategory = new ComboBox();
            chkDiscountOnly = new CheckBox();
            chkBestSelling = new CheckBox();
            btnSellproduct = new Button();
            txtLimitPrice = new TextBox();
            flpItems = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            btnMyOrders = new Button();
            btnMyItems = new Button();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            pictureBox5 = new PictureBox();
            label4 = new Label();
            pictureBox6 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(856, 57);
            txtSearch.Margin = new Padding(4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Enter product name";
            txtSearch.Size = new Size(396, 38);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(616, 57);
            cmbCategory.Margin = new Padding(4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(232, 39);
            cmbCategory.TabIndex = 0;
            cmbCategory.SelectedValueChanged += cmbCategory_SelectedValueChanged;
            // 
            // chkDiscountOnly
            // 
            chkDiscountOnly.AutoSize = true;
            chkDiscountOnly.Location = new Point(820, 119);
            chkDiscountOnly.Margin = new Padding(4);
            chkDiscountOnly.Name = "chkDiscountOnly";
            chkDiscountOnly.Size = new Size(171, 35);
            chkDiscountOnly.TabIndex = 13;
            chkDiscountOnly.Text = "Discount Only";
            chkDiscountOnly.UseVisualStyleBackColor = true;
            chkDiscountOnly.CheckedChanged += chkDiscountOnly_CheckedChanged;
            // 
            // chkBestSelling
            // 
            chkBestSelling.AutoSize = true;
            chkBestSelling.Location = new Point(1008, 121);
            chkBestSelling.Margin = new Padding(4);
            chkBestSelling.Name = "chkBestSelling";
            chkBestSelling.Size = new Size(144, 35);
            chkBestSelling.TabIndex = 14;
            chkBestSelling.Text = "Best Selling";
            chkBestSelling.UseVisualStyleBackColor = true;
            chkBestSelling.CheckedChanged += chkBestSelling_CheckedChanged;
            // 
            // btnSellproduct
            // 
            btnSellproduct.Location = new Point(10, 50);
            btnSellproduct.Margin = new Padding(4);
            btnSellproduct.Name = "btnSellproduct";
            btnSellproduct.Size = new Size(200, 50);
            btnSellproduct.TabIndex = 15;
            btnSellproduct.Text = "Sell a product";
            btnSellproduct.UseVisualStyleBackColor = true;
            btnSellproduct.Visible = false;
            btnSellproduct.Click += btnSellproduct_Click;
            // 
            // txtLimitPrice
            // 
            txtLimitPrice.Location = new Point(616, 119);
            txtLimitPrice.Margin = new Padding(4);
            txtLimitPrice.Name = "txtLimitPrice";
            txtLimitPrice.PlaceholderText = "Price Limit";
            txtLimitPrice.Size = new Size(179, 38);
            txtLimitPrice.TabIndex = 16;
            txtLimitPrice.KeyDown += txtLimitPrice_KeyDown;
            // 
            // flpItems
            // 
            flpItems.AutoScroll = true;
            flpItems.FlowDirection = FlowDirection.TopDown;
            flpItems.Location = new Point(305, 165);
            flpItems.Margin = new Padding(4);
            flpItems.Name = "flpItems";
            flpItems.Size = new Size(1235, 700);
            flpItems.TabIndex = 17;
            flpItems.WrapContents = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-42, 612);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(338, 356);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 57;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ScrollBar;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(10, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 58;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(114, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 59;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 18);
            label1.Name = "label1";
            label1.Size = new Size(81, 31);
            label1.TabIndex = 60;
            label1.Text = "LogOut";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 18);
            label2.Name = "label2";
            label2.Size = new Size(67, 31);
            label2.TabIndex = 61;
            label2.Text = "Menu";
            // 
            // btnMyOrders
            // 
            btnMyOrders.Location = new Point(10, 141);
            btnMyOrders.Margin = new Padding(4);
            btnMyOrders.Name = "btnMyOrders";
            btnMyOrders.Size = new Size(200, 50);
            btnMyOrders.TabIndex = 65;
            btnMyOrders.Text = "My Items";
            btnMyOrders.UseVisualStyleBackColor = true;
            btnMyOrders.Visible = false;
            btnMyOrders.Click += btnMyOrders_Click;
            // 
            // btnMyItems
            // 
            btnMyItems.Location = new Point(10, 96);
            btnMyItems.Margin = new Padding(4);
            btnMyItems.Name = "btnMyItems";
            btnMyItems.Size = new Size(200, 50);
            btnMyItems.TabIndex = 64;
            btnMyItems.Text = "My Orders";
            btnMyItems.UseVisualStyleBackColor = true;
            btnMyItems.Visible = false;
            btnMyItems.Click += btnMyItems_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(236, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(44, 37);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 67;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(273, 18);
            label3.Name = "label3";
            label3.Size = new Size(53, 31);
            label3.TabIndex = 68;
            label3.Text = "Cart";
            // 
            // pictureBox5
            // 
            pictureBox5.BorderStyle = BorderStyle.Fixed3D;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(332, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(44, 37);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 69;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(373, 18);
            label4.Name = "label4";
            label4.Size = new Size(146, 31);
            label4.TabIndex = 70;
            label4.Text = "Your Account ";
            // 
            // pictureBox6
            // 
            pictureBox6.BorderStyle = BorderStyle.Fixed3D;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(507, 12);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(44, 37);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 71;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(546, 18);
            label5.Name = "label5";
            label5.Size = new Size(130, 31);
            label5.TabIndex = 72;
            label5.Text = "Notifications";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1567, 916);
            Controls.Add(label5);
            Controls.Add(pictureBox6);
            Controls.Add(label4);
            Controls.Add(pictureBox5);
            Controls.Add(label3);
            Controls.Add(pictureBox4);
            Controls.Add(btnMyOrders);
            Controls.Add(btnMyItems);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(flpItems);
            Controls.Add(txtLimitPrice);
            Controls.Add(btnSellproduct);
            Controls.Add(chkBestSelling);
            Controls.Add(chkDiscountOnly);
            Controls.Add(txtSearch);
            Controls.Add(cmbCategory);
            Font = new Font("Andalus", 10F, FontStyle.Bold);
            ForeColor = Color.FromArgb(192, 0, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Online Shopping & Selling App";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSearch;
        private ComboBox cmbCategory;
        private CheckBox chkDiscountOnly;
        private CheckBox chkBestSelling;
        private Button btnSellproduct;
        private TextBox txtLimitPrice;
        private FlowLayoutPanel flpItems;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private Button btnMyOrders;
        private Button btnMyItems;
        private PictureBox pictureBox4;
        private Label label3;
        private PictureBox pictureBox5;
        private Label label4;
        private PictureBox pictureBox6;
        private Label label5;
    }
}
