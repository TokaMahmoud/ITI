namespace OnlineShoppingApp
{
    partial class CartItemUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDeliveryTime = new Label();
            lblDescription = new Label();
            lblDiscount = new Label();
            lblPrice = new Label();
            lblName = new Label();
            pbItemPhoto = new PictureBox();
            btnDeleteFromCart = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbItemPhoto).BeginInit();
            SuspendLayout();
            // 
            // lblDeliveryTime
            // 
            lblDeliveryTime.AutoSize = true;
            lblDeliveryTime.Location = new Point(844, 31);
            lblDeliveryTime.Margin = new Padding(4, 0, 4, 0);
            lblDeliveryTime.Name = "lblDeliveryTime";
            lblDeliveryTime.Size = new Size(141, 31);
            lblDeliveryTime.TabIndex = 18;
            lblDeliveryTime.Text = "Delivery Time";
            // 
            // lblDescription
            // 
            lblDescription.Location = new Point(366, 162);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(551, 177);
            lblDescription.TabIndex = 15;
            lblDescription.Text = "label5";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(702, 98);
            lblDiscount.Margin = new Padding(4, 0, 4, 0);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(91, 31);
            lblDiscount.TabIndex = 14;
            lblDiscount.Text = "discount";
            lblDiscount.Visible = false;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(366, 98);
            lblPrice.Margin = new Padding(4, 0, 4, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(69, 31);
            lblPrice.TabIndex = 13;
            lblPrice.Text = "label3";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(366, 31);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(69, 31);
            lblName.TabIndex = 11;
            lblName.Text = "label1";
            // 
            // pbItemPhoto
            // 
            pbItemPhoto.Location = new Point(4, 4);
            pbItemPhoto.Margin = new Padding(4);
            pbItemPhoto.Name = "pbItemPhoto";
            pbItemPhoto.Size = new Size(354, 347);
            pbItemPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbItemPhoto.TabIndex = 10;
            pbItemPhoto.TabStop = false;
            // 
            // btnDeleteFromCart
            // 
            btnDeleteFromCart.Location = new Point(956, 156);
            btnDeleteFromCart.Margin = new Padding(4);
            btnDeleteFromCart.Name = "btnDeleteFromCart";
            btnDeleteFromCart.Size = new Size(134, 42);
            btnDeleteFromCart.TabIndex = 19;
            btnDeleteFromCart.Text = "Delete Item";
            btnDeleteFromCart.UseVisualStyleBackColor = true;
            btnDeleteFromCart.Click += btnDeleteFromCart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(700, 31);
            label1.Name = "label1";
            label1.Size = new Size(137, 31);
            label1.TabIndex = 20;
            label1.Text = "Delivery time";
            // 
            // CartItemUserControl
            // 
            AutoScaleDimensions = new SizeF(12F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(label1);
            Controls.Add(btnDeleteFromCart);
            Controls.Add(lblDeliveryTime);
            Controls.Add(lblDescription);
            Controls.Add(lblDiscount);
            Controls.Add(lblPrice);
            Controls.Add(lblName);
            Controls.Add(pbItemPhoto);
            Font = new Font("Andalus", 10F, FontStyle.Bold);
            ForeColor = Color.FromArgb(192, 0, 0);
            Margin = new Padding(4);
            Name = "CartItemUserControl";
            Size = new Size(1226, 354);
            ((System.ComponentModel.ISupportInitialize)pbItemPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDeliveryTime;
        private Label lblDescription;
        private Label lblDiscount;
        private Label lblPrice;
        private Label lblName;
        private PictureBox pbItemPhoto;
        private Button btnDeleteFromCart;
        private Label label1;
    }
}
