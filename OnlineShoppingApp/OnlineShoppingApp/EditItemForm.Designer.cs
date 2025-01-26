namespace OnlineShoppingApp
{
    partial class EditItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditItemForm));
            btnUploadPhoto = new Button();
            pbItemPhoto = new PictureBox();
            label8 = new Label();
            numericUpDownDelivTim = new NumericUpDown();
            label7 = new Label();
            numericUpDownQuantity = new NumericUpDown();
            cmbPcategory = new ComboBox();
            txtPname = new TextBox();
            txtPdesc = new TextBox();
            txtPprice = new TextBox();
            txtPdiscount = new TextBox();
            btnSave = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCancel = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbItemPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDelivTim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnUploadPhoto
            // 
            btnUploadPhoto.Location = new Point(743, 352);
            btnUploadPhoto.Margin = new Padding(4);
            btnUploadPhoto.Name = "btnUploadPhoto";
            btnUploadPhoto.Size = new Size(161, 42);
            btnUploadPhoto.TabIndex = 37;
            btnUploadPhoto.Text = "Upload Photo";
            btnUploadPhoto.UseVisualStyleBackColor = true;
            btnUploadPhoto.Click += btnUploadPhoto_Click;
            // 
            // pbItemPhoto
            // 
            pbItemPhoto.Location = new Point(483, 326);
            pbItemPhoto.Margin = new Padding(4);
            pbItemPhoto.Name = "pbItemPhoto";
            pbItemPhoto.Size = new Size(180, 93);
            pbItemPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbItemPhoto.TabIndex = 36;
            pbItemPhoto.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(263, 352);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(66, 31);
            label8.TabIndex = 35;
            label8.Text = "Photo";
            // 
            // numericUpDownDelivTim
            // 
            numericUpDownDelivTim.Location = new Point(483, 452);
            numericUpDownDelivTim.Margin = new Padding(4);
            numericUpDownDelivTim.Name = "numericUpDownDelivTim";
            numericUpDownDelivTim.Size = new Size(154, 38);
            numericUpDownDelivTim.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(263, 452);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(141, 31);
            label7.TabIndex = 33;
            label7.Text = "Delivery Time";
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(483, 537);
            numericUpDownQuantity.Margin = new Padding(4);
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(154, 38);
            numericUpDownQuantity.TabIndex = 32;
            // 
            // cmbPcategory
            // 
            cmbPcategory.FormattingEnabled = true;
            cmbPcategory.Location = new Point(483, 90);
            cmbPcategory.Margin = new Padding(4);
            cmbPcategory.Name = "cmbPcategory";
            cmbPcategory.Size = new Size(309, 39);
            cmbPcategory.TabIndex = 31;
            // 
            // txtPname
            // 
            txtPname.Location = new Point(483, 13);
            txtPname.Margin = new Padding(4);
            txtPname.Name = "txtPname";
            txtPname.Size = new Size(309, 38);
            txtPname.TabIndex = 30;
            // 
            // txtPdesc
            // 
            txtPdesc.Location = new Point(483, 605);
            txtPdesc.Margin = new Padding(4);
            txtPdesc.MaxLength = 32767000;
            txtPdesc.Multiline = true;
            txtPdesc.Name = "txtPdesc";
            txtPdesc.Size = new Size(473, 117);
            txtPdesc.TabIndex = 29;
            // 
            // txtPprice
            // 
            txtPprice.Location = new Point(483, 176);
            txtPprice.Margin = new Padding(4);
            txtPprice.Name = "txtPprice";
            txtPprice.Size = new Size(309, 38);
            txtPprice.TabIndex = 28;
            // 
            // txtPdiscount
            // 
            txtPdiscount.Location = new Point(483, 258);
            txtPdiscount.Margin = new Padding(4);
            txtPdiscount.Name = "txtPdiscount";
            txtPdiscount.Size = new Size(309, 38);
            txtPdiscount.TabIndex = 27;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(311, 757);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(187, 42);
            btnSave.TabIndex = 26;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(263, 537);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(94, 31);
            label6.TabIndex = 25;
            label6.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(263, 176);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(60, 31);
            label5.TabIndex = 24;
            label5.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(263, 265);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(167, 31);
            label4.TabIndex = 23;
            label4.Text = "DiscountAmount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 90);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 31);
            label3.TabIndex = 22;
            label3.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 605);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 31);
            label2.TabIndex = 21;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(263, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 31);
            label1.TabIndex = 20;
            label1.Text = "Name";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(529, 757);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(134, 42);
            btnCancel.TabIndex = 38;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-44, 586);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(283, 324);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
            // 
            // EditItemForm
            // 
            AutoScaleDimensions = new SizeF(12F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1000, 859);
            Controls.Add(pictureBox1);
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
            Controls.Add(btnSave);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Andalus", 10F, FontStyle.Bold);
            ForeColor = Color.FromArgb(192, 0, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "EditItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Online Shopping & Selling App";
            Load += EditItemForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbItemPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDelivTim).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUploadPhoto;
        private PictureBox pbItemPhoto;
        private Label label8;
        private NumericUpDown numericUpDownDelivTim;
        private Label label7;
        private NumericUpDown numericUpDownQuantity;
        private ComboBox cmbPcategory;
        private TextBox txtPname;
        private TextBox txtPdesc;
        private TextBox txtPprice;
        private TextBox txtPdiscount;
        private Button btnSave;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCancel;
        private PictureBox pictureBox1;
    }
}