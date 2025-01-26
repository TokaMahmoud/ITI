using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using OnlineShoppingApp.Models;

namespace OnlineShoppingApp
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Retrieve user input
            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            string address = txtAddress.Text.Trim();
            string email = txtEmail.Text.Trim();
            string visaCardNumber = txtVisaCardNumber.Text.Trim();
            string phoneNumber = txtPhone.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(visaCardNumber) || string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Please fill in all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate email format
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate phone number format (10-15 digits)
            if (!System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^\d{10,15}$"))
            {
                MessageBox.Show("Invalid phone number. It must be between 10 to 15 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Visa card number format (16 digits)
            if (!System.Text.RegularExpressions.Regex.IsMatch(visaCardNumber, @"^\d{16}$"))
            {
                MessageBox.Show("Invalid Visa card number. It must be 16 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate password strength (minimum 6 characters, with at least one letter and one digit)
            if (password.Length < 6 || !password.Any(char.IsLetter) || !password.Any(char.IsDigit))
            {
                MessageBox.Show("Password must be at least 6 characters long and contain at least one letter and one digit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Save the user to the database
            using (var context = new AppDbContext())
            {
                // Check for duplicate username or email
                if (context.Users.Any(u => u.UserName == userName || u.Email == email))
                {
                    MessageBox.Show("Username or email already exists.", "Sign-Up Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Add new user
                var newUser = new Models.User()
                {
                    UserName = userName,
                    Password = password,
                    Address = address,
                    Email = email,
                    VisaCardNumber = visaCardNumber,
                    Phone = phoneNumber
                };

                context.Users.Add(newUser);
                context.SaveChanges();
                Session.CurrentUser = newUser;

                MessageBox.Show("Sign-Up Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Move to the login form
                LoginForm mainForm = new LoginForm();
                mainForm.Show();
                this.Hide();
            }
        }

        // Helper method to validate email format
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoginForm ProductRegistrationForm = new LoginForm();
            foreach (Form form in Application.OpenForms)
            {
                form.Hide();
            }
            ProductRegistrationForm.Show();
        }
    }
}
