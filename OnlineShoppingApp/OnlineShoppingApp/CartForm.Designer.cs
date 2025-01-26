namespace OnlineShoppingApp
{
    partial class CartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartForm));
            lab4 = new Label();
            lab1 = new Label();
            lblDeliFee = new Label();
            lblTotalPrice = new Label();
            btnCancelCart = new Button();
            btnCheckout = new Button();
            cmbPaymentMethod = new ComboBox();
            flpCartItems = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBoxBack = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).BeginInit();
            SuspendLayout();
            // 
            // lab4
            // 
            lab4.AutoSize = true;
            lab4.Location = new Point(263, 627);
            lab4.Margin = new Padding(4, 0, 4, 0);
            lab4.Name = "lab4";
            lab4.Size = new Size(111, 31);
            lab4.TabIndex = 2;
            lab4.Text = "Total Price";
            // 
            // lab1
            // 
            lab1.AutoSize = true;
            lab1.Location = new Point(263, 564);
            lab1.Margin = new Padding(4, 0, 4, 0);
            lab1.Name = "lab1";
            lab1.Size = new Size(127, 31);
            lab1.TabIndex = 3;
            lab1.Text = "Delivery Fee";
            // 
            // lblDeliFee
            // 
            lblDeliFee.AutoSize = true;
            lblDeliFee.Location = new Point(430, 564);
            lblDeliFee.Margin = new Padding(4, 0, 4, 0);
            lblDeliFee.Name = "lblDeliFee";
            lblDeliFee.Size = new Size(69, 31);
            lblDeliFee.TabIndex = 4;
            lblDeliFee.Text = "label2";
            lblDeliFee.TextAlign = ContentAlignment.BottomLeft;
            lblDeliFee.Click += labDeliFee_Click;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(430, 627);
            lblTotalPrice.Margin = new Padding(4, 0, 4, 0);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(69, 31);
            lblTotalPrice.TabIndex = 5;
            lblTotalPrice.Text = "label3";
            // 
            // btnCancelCart
            // 
            btnCancelCart.Location = new Point(729, 697);
            btnCancelCart.Margin = new Padding(4);
            btnCancelCart.Name = "btnCancelCart";
            btnCancelCart.Size = new Size(134, 42);
            btnCancelCart.TabIndex = 7;
            btnCancelCart.Text = "Cancel";
            btnCancelCart.UseVisualStyleBackColor = true;
            btnCancelCart.Click += btnCancelCart_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(538, 694);
            btnCheckout.Margin = new Padding(4);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(134, 42);
            btnCheckout.TabIndex = 8;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.BackColor = Color.White;
            cmbPaymentMethod.ForeColor = Color.FromArgb(192, 0, 0);
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Location = new Point(263, 697);
            cmbPaymentMethod.Margin = new Padding(4);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(218, 39);
            cmbPaymentMethod.TabIndex = 9;
            cmbPaymentMethod.Text = "Payment Method";
            // 
            // flpCartItems
            // 
            flpCartItems.AutoScroll = true;
            flpCartItems.FlowDirection = FlowDirection.TopDown;
            flpCartItems.Location = new Point(12, 56);
            flpCartItems.Margin = new Padding(4);
            flpCartItems.Name = "flpCartItems";
            flpCartItems.Size = new Size(1226, 500);
            flpCartItems.TabIndex = 10;
            flpCartItems.WrapContents = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-56, 564);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 294);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 55;
            pictureBox1.TabStop = false;
            // 
            // pictureBoxBack
            // 
            pictureBoxBack.BackColor = SystemColors.ScrollBar;
            pictureBoxBack.BackgroundImageLayout = ImageLayout.None;
            pictureBoxBack.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxBack.Image = (Image)resources.GetObject("pictureBoxBack.Image");
            pictureBoxBack.Location = new Point(12, 12);
            pictureBoxBack.Name = "pictureBoxBack";
            pictureBoxBack.Size = new Size(44, 37);
            pictureBoxBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBack.TabIndex = 0;
            pictureBoxBack.TabStop = false;
            pictureBoxBack.Click += pictureBoxBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Andalus", 10F, FontStyle.Bold);
            label1.Location = new Point(52, 18);
            label1.Name = "label1";
            label1.Size = new Size(67, 31);
            label1.TabIndex = 56;
            label1.Text = "Home";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(12F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1256, 832);
            Controls.Add(label1);
            Controls.Add(pictureBoxBack);
            Controls.Add(pictureBox1);
            Controls.Add(flpCartItems);
            Controls.Add(cmbPaymentMethod);
            Controls.Add(btnCheckout);
            Controls.Add(btnCancelCart);
            Controls.Add(lblTotalPrice);
            Controls.Add(lblDeliFee);
            Controls.Add(lab1);
            Controls.Add(lab4);
            Font = new Font("Andalus", 10F, FontStyle.Bold);
            ForeColor = Color.FromArgb(192, 0, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "CartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Online Shopping & Selling App";
            Load += CartForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lab4;
        private Label lab1;
        private Label lblDeliFee;
        private Label lblTotalPrice;
        private Button btnCancelCart;
        private Button btnCheckout;
        private ComboBox cmbPaymentMethod;
        private FlowLayoutPanel flpCartItems;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxBack;
        private Label label1;
    }
}