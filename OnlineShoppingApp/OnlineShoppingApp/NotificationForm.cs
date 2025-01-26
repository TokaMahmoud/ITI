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

namespace OnlineShoppingApp
{
    public partial class NotificationForm : Form
    {
        public NotificationForm()
        {
            InitializeComponent();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show(); // Show the main form
            this.Close();    // Close the current form
        }

        private void LoadNotifications()
        {
            using (var context = new AppDbContext())
            {
                var notifications = context.notifications
                    .Where(n => n.SellerId == Session.CurrentUser.Id)
                    .OrderByDescending(n => n.Timestamp)
                    .ToList();

                dgvNotifications.DataSource = notifications.Select(n => new
                {
                    Message = n.Message,
                    Timestamp = n.Timestamp.ToString("yyyy-MM-dd HH:mm"),
                    //Status = n.IsRead ? "Read" : "Unread"
                }).ToList();
            }
        }

        private void NotificationForm_Load(object sender, EventArgs e)
        {
            LoadNotifications();
        }
    }
}
