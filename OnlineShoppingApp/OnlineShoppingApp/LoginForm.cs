using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineShoppingApp.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OnlineShoppingApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Retrieve user input
            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check credentials in the database
            using (var context = new AppDbContext())
            {
                var user = context.Users
                           .FirstOrDefault(u => u.UserName == userName && u.Password == password);
                if (user != null)
                {
                    // Login successful
                    Session.CurrentUser = user;

                    // Navigate to the main page
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    // Login failed
                    MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Open the Sign-Up Form
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }
    }
}
