namespace OnlineShoppingApp
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            txtVisaCardNumber = new TextBox();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            btnSignUp = new Button();
            label6 = new Label();
            txtPhone = new TextBox();
            pictureBox1 = new PictureBox();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(236, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(114, 31);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 89);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 31);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(236, 170);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 31);
            label3.TabIndex = 2;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(236, 243);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 31);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(236, 398);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(180, 31);
            label5.TabIndex = 4;
            label5.Text = "Visa Card Number";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(456, 170);
            txtAddress.Margin = new Padding(4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(179, 38);
            txtAddress.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(456, 243);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(179, 38);
            txtEmail.TabIndex = 6;
            // 
            // txtVisaCardNumber
            // 
            txtVisaCardNumber.Location = new Point(456, 398);
            txtVisaCardNumber.Margin = new Padding(4);
            txtVisaCardNumber.Name = "txtVisaCardNumber";
            txtVisaCardNumber.Size = new Size(179, 38);
            txtVisaCardNumber.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(456, 89);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(179, 38);
            txtPassword.TabIndex = 8;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(456, 23);
            txtUserName.Margin = new Padding(4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(179, 38);
            txtUserName.TabIndex = 9;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(282, 483);
            btnSignUp.Margin = new Padding(4);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(134, 42);
            btnSignUp.TabIndex = 10;
            btnSignUp.Text = "SignUp";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(236, 316);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(150, 31);
            label6.TabIndex = 11;
            label6.Text = "Phone Number";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(456, 316);
            txtPhone.Margin = new Padding(4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(179, 38);
            txtPhone.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-31, 278);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(288, 319);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 60;
            pictureBox1.TabStop = false;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(456, 483);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(171, 42);
            btnCancel.TabIndex = 61;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(12F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(675, 555);
            Controls.Add(btnCancel);
            Controls.Add(txtPhone);
            Controls.Add(label6);
            Controls.Add(btnSignUp);
            Controls.Add(txtUserName);
            Controls.Add(txtPassword);
            Controls.Add(txtVisaCardNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtAddress);
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
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Online Shopping & Selling App";
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
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtVisaCardNumber;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Button btnSignUp;
        private Label label6;
        private TextBox txtPhone;
        private PictureBox pictureBox1;
        private Button btnCancel;
    }
}