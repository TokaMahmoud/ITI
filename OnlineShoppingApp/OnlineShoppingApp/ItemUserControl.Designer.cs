namespace OnlineShoppingApp
{
    partial class ItemUserControl
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
            pbItemPhoto = new PictureBox();
            lblName = new Label();
            lblPurchaseCount = new Label();
            lblPrice = new Label();
            lblDiscount = new Label();
            lblDescription = new Label();
            btnAddToCart = new Button();
            lblSellerName = new Label();
            lblDeliveryTime = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbItemPhoto).BeginInit();
            SuspendLayout();
            // 
            // pbItemPhoto
            // 
            pbItemPhoto.Location = new Point(4, 0);
            pbItemPhoto.Margin = new Padding(4);
            pbItemPhoto.Name = "pbItemPhoto";
            pbItemPhoto.Size = new Size(354, 347);
            pbItemPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbItemPhoto.TabIndex = 0;
            pbItemPhoto.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Andalus", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblName.Location = new Point(361, 17);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(101, 46);
            lblName.TabIndex = 1;
            lblName.Text = "label1";
            // 
            // lblPurchaseCount
            // 
            lblPurchaseCount.AutoSize = true;
            lblPurchaseCount.Location = new Point(361, 69);
            lblPurchaseCount.Margin = new Padding(4, 0, 4, 0);
            lblPurchaseCount.Name = "lblPurchaseCount";
            lblPurchaseCount.Size = new Size(69, 31);
            lblPurchaseCount.TabIndex = 2;
            lblPurchaseCount.Text = "label2";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(361, 118);
            lblPrice.Margin = new Padding(4, 0, 4, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(69, 31);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "label3";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(726, 118);
            lblDiscount.Margin = new Padding(4, 0, 4, 0);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(91, 31);
            lblDiscount.TabIndex = 4;
            lblDiscount.Text = "discount";
            // 
            // lblDescription
            // 
            lblDescription.Location = new Point(361, 174);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(551, 177);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "label5";
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(939, 118);
            btnAddToCart.Margin = new Padding(4);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(142, 42);
            btnAddToCart.TabIndex = 7;
            btnAddToCart.Text = "Add To Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += BtnAddToCart_Click;
            // 
            // lblSellerName
            // 
            lblSellerName.AutoSize = true;
            lblSellerName.Location = new Point(726, 27);
            lblSellerName.Margin = new Padding(4, 0, 4, 0);
            lblSellerName.Name = "lblSellerName";
            lblSellerName.Size = new Size(63, 31);
            lblSellerName.TabIndex = 8;
            lblSellerName.Text = "seller";
            // 
            // lblDeliveryTime
            // 
            lblDeliveryTime.AutoSize = true;
            lblDeliveryTime.Location = new Point(862, 67);
            lblDeliveryTime.Margin = new Padding(4, 0, 4, 0);
            lblDeliveryTime.Name = "lblDeliveryTime";
            lblDeliveryTime.Size = new Size(141, 31);
            lblDeliveryTime.TabIndex = 9;
            lblDeliveryTime.Text = "Delivery Time";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(726, 67);
            label1.Name = "label1";
            label1.Size = new Size(141, 31);
            label1.TabIndex = 10;
            label1.Text = "Delivery Time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(898, 67);
            label2.Name = "label2";
            label2.Size = new Size(53, 31);
            label2.TabIndex = 11;
            label2.Text = "days";
            // 
            // ItemUserControl
            // 
            AutoScaleDimensions = new SizeF(12F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblDeliveryTime);
            Controls.Add(lblSellerName);
            Controls.Add(btnAddToCart);
            Controls.Add(lblDescription);
            Controls.Add(lblDiscount);
            Controls.Add(lblPrice);
            Controls.Add(lblPurchaseCount);
            Controls.Add(lblName);
            Controls.Add(pbItemPhoto);
            Font = new Font("Andalus", 10F, FontStyle.Bold);
            ForeColor = Color.FromArgb(192, 0, 0);
            Margin = new Padding(4);
            Name = "ItemUserControl";
            Size = new Size(1226, 354);
            ((System.ComponentModel.ISupportInitialize)pbItemPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbItemPhoto;
        private Label lblName;
        private Label lblPurchaseCount;
        private Label lblPrice;
        private Label lblDiscount;
        private Label lblDescription;
        private Button btnAddToCart;
        private Label lblSellerName;
        private Label lblDeliveryTime;
        private Label label1;
        private Label label2;
    }
}
