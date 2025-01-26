namespace OnlineShoppingApp
{
    partial class AccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            pnlMyAccount = new Panel();
            btnDeleteAcc = new Button();
            btnLogout = new Button();
            btnUpdateDetails = new Button();
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtPassword = new TextBox();
            txtVisaNumber = new TextBox();
            txtAddress = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBoxBack = new PictureBox();
            label7 = new Label();
            pnlMyAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).BeginInit();
            SuspendLayout();
            // 
            // pnlMyAccount
            // 
            pnlMyAccount.Controls.Add(btnDeleteAcc);
            pnlMyAccount.Controls.Add(btnLogout);
            pnlMyAccount.Controls.Add(btnUpdateDetails);
            pnlMyAccount.Controls.Add(txtName);
            pnlMyAccount.Controls.Add(label1);
            pnlMyAccount.Controls.Add(label2);
            pnlMyAccount.Controls.Add(label3);
            pnlMyAccount.Controls.Add(label4);
            pnlMyAccount.Controls.Add(label5);
            pnlMyAccount.Controls.Add(label6);
            pnlMyAccount.Controls.Add(txtEmail);
            pnlMyAccount.Controls.Add(txtPhone);
            pnlMyAccount.Controls.Add(txtPassword);
            pnlMyAccount.Controls.Add(txtVisaNumber);
            pnlMyAccount.Controls.Add(txtAddress);
            pnlMyAccount.Location = new Point(226, 12);
            pnlMyAccount.Margin = new Padding(4);
            pnlMyAccount.Name = "pnlMyAccount";
            pnlMyAccount.Size = new Size(661, 463);
            pnlMyAccount.TabIndex = 51;
            pnlMyAccount.Paint += pnlMyAccount_Paint;
            // 
            // btnDeleteAcc
            // 
            btnDeleteAcc.Location = new Point(454, 282);
            btnDeleteAcc.Name = "btnDeleteAcc";
            btnDeleteAcc.Size = new Size(191, 52);
            btnDeleteAcc.TabIndex = 47;
            btnDeleteAcc.Text = "Delete Account";
            btnDeleteAcc.UseVisualStyleBackColor = true;
            btnDeleteAcc.Click += btnDeleteAcc_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(454, 136);
            btnLogout.Margin = new Padding(4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(191, 52);
            btnLogout.TabIndex = 46;
            btnLogout.Text = "Logout ";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnUpdateDetails
            // 
            btnUpdateDetails.Location = new Point(454, 208);
            btnUpdateDetails.Margin = new Padding(4);
            btnUpdateDetails.Name = "btnUpdateDetails";
            btnUpdateDetails.Size = new Size(191, 52);
            btnUpdateDetails.TabIndex = 41;
            btnUpdateDetails.Text = "Update Details";
            btnUpdateDetails.UseVisualStyleBackColor = true;
            btnUpdateDetails.Click += btnUpdateDetails_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(205, 38);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(179, 38);
            txtName.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 44);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(114, 31);
            label1.TabIndex = 29;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 113);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 31);
            label2.TabIndex = 30;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 185);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(98, 31);
            label3.TabIndex = 31;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 259);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(84, 31);
            label4.TabIndex = 32;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 329);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(125, 31);
            label5.TabIndex = 33;
            label5.Text = "VisaNumber";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 408);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(70, 31);
            label6.TabIndex = 34;
            label6.Text = "Phone";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(205, 105);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(179, 38);
            txtEmail.TabIndex = 36;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(205, 400);
            txtPhone.Margin = new Padding(4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(179, 38);
            txtPhone.TabIndex = 40;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(205, 177);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(179, 38);
            txtPassword.TabIndex = 37;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtVisaNumber
            // 
            txtVisaNumber.Location = new Point(205, 321);
            txtVisaNumber.Margin = new Padding(4);
            txtVisaNumber.Name = "txtVisaNumber";
            txtVisaNumber.Size = new Size(179, 38);
            txtVisaNumber.TabIndex = 39;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(205, 251);
            txtAddress.Margin = new Padding(4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(179, 38);
            txtAddress.TabIndex = 38;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-29, 333);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 252);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 54;
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
            pictureBoxBack.TabIndex = 56;
            pictureBoxBack.TabStop = false;
            pictureBoxBack.Click += pictureBoxBack_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(53, 18);
            label7.Name = "label7";
            label7.Size = new Size(67, 31);
            label7.TabIndex = 57;
            label7.Text = "Home";
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(12F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(930, 542);
            Controls.Add(label7);
            Controls.Add(pictureBoxBack);
            Controls.Add(pnlMyAccount);
            Controls.Add(pictureBox1);
            Font = new Font("Andalus", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(192, 0, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "AccountForm";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Online Shopping & Selling App";
            Scroll += Account2_Scroll;
            pnlMyAccount.ResumeLayout(false);
            pnlMyAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlMyAccount;
        private Button btnLogout;
        private Button btnUpdateDetails;
        private TextBox txtName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtPassword;
        private TextBox txtVisaNumber;
        private TextBox txtAddress;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxBack;
        private Button btnDeleteAcc;
        private Label label7;
    }
}