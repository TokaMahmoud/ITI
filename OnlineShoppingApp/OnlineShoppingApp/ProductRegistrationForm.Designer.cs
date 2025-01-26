namespace OnlineShoppingApp
{
    partial class ProductRegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductRegistrationForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnPsubmit = new Button();
            txtPdesc = new TextBox();
            txtPname = new TextBox();
            cmbPcategory = new ComboBox();
            txtPdiscount = new TextBox();
            txtPprice = new TextBox();
            numericUpDownQuantity = new NumericUpDown();
            label7 = new Label();
            numericUpDownDelivTim = new NumericUpDown();
            label8 = new Label();
            pbItemPhoto = new PictureBox();
            btnUploadPhoto = new Button();
            pictureBox1 = new PictureBox();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDelivTim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbItemPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 31);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 624);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 31);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 109);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 31);
            label3.TabIndex = 2;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(231, 284);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(167, 31);
            label4.TabIndex = 3;
            label4.Text = "DiscountAmount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(231, 195);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(60, 31);
            label5.TabIndex = 4;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(231, 556);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(94, 31);
            label6.TabIndex = 5;
            label6.Text = "Quantity";
            // 
            // btnPsubmit
            // 
            btnPsubmit.Location = new Point(328, 772);
            btnPsubmit.Margin = new Padding(4);
            btnPsubmit.Name = "btnPsubmit";
            btnPsubmit.Size = new Size(171, 42);
            btnPsubmit.TabIndex = 6;
            btnPsubmit.Text = "ADD";
            btnPsubmit.UseVisualStyleBackColor = true;
            btnPsubmit.Click += btnPsubmit_Click;
            // 
            // txtPdesc
            // 
            txtPdesc.Location = new Point(451, 624);
            txtPdesc.Margin = new Padding(4);
            txtPdesc.MaxLength = 32767000;
            txtPdesc.Multiline = true;
            txtPdesc.Name = "txtPdesc";
            txtPdesc.Size = new Size(473, 117);
            txtPdesc.TabIndex = 11;
            // 
            // txtPname
            // 
            txtPname.Location = new Point(451, 32);
            txtPname.Margin = new Padding(4);
            txtPname.Name = "txtPname";
            txtPname.Size = new Size(309, 38);
            txtPname.TabIndex = 12;
            // 
            // cmbPcategory
            // 
            cmbPcategory.FormattingEnabled = true;
            cmbPcategory.Location = new Point(451, 109);
            cmbPcategory.Margin = new Padding(4);
            cmbPcategory.Name = "cmbPcategory";
            cmbPcategory.Size = new Size(309, 39);
            cmbPcategory.TabIndex = 13;
            // 
            // txtPdiscount
            // 
            txtPdiscount.Location = new Point(451, 277);
            txtPdiscount.Margin = new Padding(4);
            txtPdiscount.Name = "txtPdiscount";
            txtPdiscount.Size = new Size(309, 38);
            txtPdiscount.TabIndex = 7;
            // 
            // txtPprice
            // 
            txtPprice.Location = new Point(451, 195);
            txtPprice.Margin = new Padding(4);
            txtPprice.Name = "txtPprice";
            txtPprice.Size = new Size(309, 38);
            txtPprice.TabIndex = 8;
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(451, 556);
            numericUpDownQuantity.Margin = new Padding(4);
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(154, 38);
            numericUpDownQuantity.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(231, 471);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(141, 31);
            label7.TabIndex = 15;
            label7.Text = "Delivery Time";
            // 
            // numericUpDownDelivTim
            // 
            numericUpDownDelivTim.Location = new Point(451, 471);
            numericUpDownDelivTim.Margin = new Padding(4);
            numericUpDownDelivTim.Name = "numericUpDownDelivTim";
            numericUpDownDelivTim.Size = new Size(154, 38);
            numericUpDownDelivTim.TabIndex = 16;
            numericUpDownDelivTim.ValueChanged += numericUpDownDelivTim_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(231, 371);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(66, 31);
            label8.TabIndex = 17;
            label8.Text = "Photo";
            // 
            // pbItemPhoto
            // 
            pbItemPhoto.Location = new Point(451, 345);
            pbItemPhoto.Margin = new Padding(4);
            pbItemPhoto.Name = "pbItemPhoto";
            pbItemPhoto.Size = new Size(180, 93);
            pbItemPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbItemPhoto.TabIndex = 18;
            pbItemPhoto.TabStop = false;
            // 
            // btnUploadPhoto
            // 
            btnUploadPhoto.Location = new Point(711, 371);
            btnUploadPhoto.Margin = new Padding(4);
            btnUploadPhoto.Name = "btnUploadPhoto";
            btnUploadPhoto.Size = new Size(161, 42);
            btnUploadPhoto.TabIndex = 19;
            btnUploadPhoto.Text = "Upload Photo";
            btnUploadPhoto.UseVisualStyleBackColor = true;
            btnUploadPhoto.Click += btnUploadPhoto_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-30, 551);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(312, 341);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 59;
            pictureBox1.TabStop = false;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(538, 772);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(171, 42);
            btnCancel.TabIndex = 60;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ProductRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(12F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(974, 850);
            Controls.Add(btnCancel);
            Controls.Add(btnUploadPhoto);
            Controls.Add(pbItemPhoto);
            Controls.Add(label8);
            Controls.Add(numericUpDownDelivTim);
            Controls.Add(label7);
            Controls.Add(numericUpDownQuantity);
            Controls.Add(cmbPcategory);
            Controls.Add(txtPname);
            Controls.Add(txtPdesc);
            Controls.Add(txtPprice);
            Controls.Add(txtPdiscount);
            Controls.Add(btnPsubmit);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Andalus", 10F, FontStyle.Bold);
            ForeColor = Color.FromArgb(192, 0, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "ProductRegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Online Shopping & Selling App";
            Load += ProductRegistrationForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDelivTim).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbItemPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnPsubmit;
        private TextBox txtPdesc;
        private TextBox txtPname;
        private ComboBox cmbPcategory;
        private TextBox txtPdiscount;
        private TextBox txtPprice;
        private NumericUpDown numericUpDownQuantity;
        private Label label7;
        private NumericUpDown numericUpDownDelivTim;
        private Label label8;
        private PictureBox pbItemPhoto;
        private Button btnUploadPhoto;
        private PictureBox pictureBox1;
        private Button btnCancel;
    }
}