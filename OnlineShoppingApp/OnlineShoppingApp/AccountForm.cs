using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using OnlineShoppingApp.Models;

namespace OnlineShoppingApp
{
    public partial class AccountForm : Form
    {
        int currentUserId = Session.CurrentUser.Id;

        public AccountForm()
        {
            InitializeComponent();
            LoadUserDetails();
        }     
        private void LoadUserDetails()
        {
            using (var context = new AppDbContext())
            {
                var user = context.Users.Find(currentUserId);

                if (user != null)
                {
                    txtName.Text = user.UserName;
                    txtEmail.Text = user.Email;
                    txtPassword.Text = user.Password;
                    txtAddress.Text = user.Address;
                    txtVisaNumber.Text = user.VisaCardNumber;
                    txtPhone.Text = user.Phone;
                }
            }
        }
 
        private void btnUpdateDetails_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var user = context.Users.Find(currentUserId);

                if (user != null)
                {
                    user.UserName = txtName.Text;
                    user.Email = txtEmail.Text;
                    user.Password = txtPassword.Text;
                    user.Address = txtAddress.Text;
                    user.VisaCardNumber = txtVisaNumber.Text;
                    user.Phone = txtPhone.Text;
                    context.Users.Update(user);
                    context.SaveChanges();
                    MessageBox.Show("Your details have been updated!");
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            foreach (Form form in Application.OpenForms)
            {
                form.Hide();
            }
            loginForm.Show();
        }

        private void Account2_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void pnlMyAccount_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show(); // Show the main form
            this.Close();    // Close the current form
        }

        private void btnDeleteAcc_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show(
                "Are you sure you want to delete your account? This action cannot be undone.",
                "Delete Account",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmation == DialogResult.Yes)
            {
                using (var context = new AppDbContext())
                {
                    // Retrieve the current user's details
                    var user = context.Users.Find(currentUserId);

                    if (user != null)
                    {
                        // Remove user's associated items for sale
                        var userItems = context.Items.Where(i => i.SellerId == currentUserId).ToList();
                        context.Items.RemoveRange(userItems);

                        // Remove user's orders as a buyer
                        var userOrders = context.Orders.Where(o => o.BuyerId == currentUserId).ToList();
                        context.Orders.RemoveRange(userOrders);

                        // Remove the user
                        context.Users.Remove(user);

                        // Save changes to the database
                        context.SaveChanges();

                        MessageBox.Show("Your account has been deleted successfully.", "Account Deleted");

                        // Log out and redirect to login form
                        var loginForm = new LoginForm();
                        foreach (Form form in Application.OpenForms)
                        {
                            form.Hide();
                        }
                        loginForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("User not found. Unable to delete the account.", "Error");
                    }
                }
            }
        }
    }
}
