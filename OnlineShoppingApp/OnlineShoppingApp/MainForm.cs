using Microsoft.EntityFrameworkCore;
using OnlineShoppingApp.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using Item = OnlineShoppingApp.Models.Item;

namespace OnlineShoppingApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadItems();
            LoadCategories();
        }
        private void LoadItems()
        {
            flpItems.Controls.Clear();

            using (var context = new AppDbContext())
            {
                var items = context.Items
                                   .Where(i => i.SellerId != Session.CurrentUser.Id && i.quantityInStock > 0) // Filter out user's own items
                                   .Select(i => new
                                   {
                                       i.Name,
                                       i.AfterPrice,
                                       i.DiscountAmount,
                                       i.PurchaseCount,
                                       i.Description,
                                       i.Photo,
                                       i.DeliverTime,
                                       SellerName = i.Seller.UserName 
                                   })
                                   .ToList();

                foreach (var item in items)
                {
                    var itemControl = new ItemUserControl
                    {
                        ItemPhoto = item.Photo != null && item.Photo.Length > 0 ? Image.FromStream(new MemoryStream(item.Photo)) : null,
                        ItemName = item.Name,
                        ItemPrice = item.AfterPrice.ToString("C"),
                        ItemDiscount = item.DiscountAmount.ToString(), 
                        ItemPurchaseCount = item.PurchaseCount.ToString(),
                        ItemDescription = item.Description,
                        ItemSellerName = item.SellerName, 
                        ItemDeliveryTime = item.DeliverTime.ToString() 
                    };

                    flpItems.Controls.Add(itemControl);
                }
            }
        }



        private void LoadCategories()
        {
            using (var context = new AppDbContext())
            {
                var categories = context.Items.Select(i => i.Category).Distinct().ToList();
                cmbCategory.Items.Clear();
                cmbCategory.Items.Add("All");
                cmbCategory.Items.AddRange(categories.ToArray());
                cmbCategory.SelectedIndex = 0;
            }
        }
        private void ApplyFilters()
        {
            using (var context = new AppDbContext())
            {
                var items = context.Items.Include(i => i.Seller).AsQueryable(); 

                // Search Filter
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    items = items.Where(i => i.Name.Contains(txtSearch.Text));
                }

                // Category Filter
                if (cmbCategory.SelectedItem != null)
                {
                    string selectedCategory = cmbCategory.SelectedItem.ToString();
                    if (selectedCategory != "All")
                    {
                        items = items.Where(i => i.Category == selectedCategory);
                    }
                }

                // Price Filter
                if (!string.IsNullOrEmpty(txtLimitPrice.Text) && decimal.TryParse(txtLimitPrice.Text, out decimal maxPrice))
                {
                    items = items.Where(i => i.AfterPrice <= maxPrice);
                }

                // Discount Filter
                if (chkDiscountOnly.Checked)
                {
                    items = items.Where(i => i.HasDiscount);
                }

                // Best Selling Filter
                if (chkBestSelling.Checked)
                {
                    items = items.Where(i => i.PurchaseCount > 5);
                }

                // Exclude the current user's items
                items = items.Where(i => i.SellerId != Session.CurrentUser.Id);

                // Clear the FlowLayoutPanel
                flpItems.Controls.Clear();

                // Populate the FlowLayoutPanel with filtered items
                foreach (var item in items.ToList())
                {
                    // Ensure Seller is not null
                    string sellerName = item.Seller != null ? item.Seller.UserName : "Unknown Seller";

                    var itemControl = new ItemUserControl
                    {
                        ItemPhoto = item.Photo != null && item.Photo.Length > 0 ? Image.FromStream(new MemoryStream(item.Photo)) : null,
                        ItemName = item.Name,
                        ItemPrice = item.AfterPrice.ToString("C"),
                        ItemDiscount = item.DiscountAmount.ToString(),
                        ItemPurchaseCount = item.PurchaseCount.ToString(),
                        ItemDescription = item.Description,
                        ItemSellerName = sellerName, // Use the seller's name
                        ItemDeliveryTime = item.DeliverTime.ToString() // Set the delivery time (in days)
                    };

                    // Add to FlowLayoutPanel
                    flpItems.Controls.Add(itemControl);
                }
            }
        }


        private void btnCart_Click(object sender, EventArgs e)
        {
            // Open the Cart Window
            CartForm cartForm = new CartForm();
            foreach (Form form in Application.OpenForms)
            {
                form.Hide();
            }
            cartForm.Show();
        }
        private void btnAccount_Click(object sender, EventArgs e)
        {
            // Open the Account Window
            AccountForm accountForm = new AccountForm();
            foreach (Form form in Application.OpenForms)
            {
                form.Hide();
            }
            accountForm.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void cmbCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void numPriceFilter_ValueChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void chkDiscountOnly_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void chkBestSelling_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void btnSellproduct_Click(object sender, EventArgs e)
        {
            ProductRegistrationForm ProductRegistrationForm = new ProductRegistrationForm();
            foreach (Form form in Application.OpenForms)
            {
                form.Hide();
            }
            ProductRegistrationForm.Show();
        }



        private void txtLimitPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Apply changes when Enter is pressed
                ApplyFilters();
            }
        }

        private void dgvItems_CellContentClick(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Apply changes when Enter is pressed
                ApplyFilters();

            }
        }

        public void btnAddToCart_Click_1(object sender, EventArgs e)
        {
            // Check if the sender is an ItemUserControl
            if (sender is ItemUserControl itemControl)
            {
                // Extract the numeric value from ItemPrice
                string numericPrice = new string(itemControl.ItemPrice.Where(c => char.IsDigit(c) || c == '.').ToArray());

                // Parse the cleaned price
                decimal price = decimal.Parse(numericPrice);
                // Retrieve item details from the ItemUserControl
                // Convert the Image to byte[] if it exists
                byte[] itemPhotoBytes = null;
                if (itemControl.ItemPhoto != null)
                {
                    using (var ms = new MemoryStream())
                    {
                        itemControl.ItemPhoto.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // Save the image to memory stream
                        itemPhotoBytes = ms.ToArray(); // Convert the stream to byte array
                    }
                }
                var cartItem = new CartItem
                {
                    Photo = itemPhotoBytes,
                    Name = itemControl.ItemName,
                    Description = itemControl.ItemDescription,
                    Price = price,

                    DeliveryDate = DateTime.Now.AddDays(int.Parse(itemControl.ItemDeliveryTime)), // Add delivery time in days
                };

                // Add to the Cart
                Cart.Items.Add(cartItem);
                Cart.TotalPrice += cartItem.Price;

                MessageBox.Show($"Item '{cartItem.Name}' added to cart.");
            }
            else
            {
                MessageBox.Show("Unable to add the item to the cart. Please try again.");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            btnSellproduct.Visible = !btnSellproduct.Visible;
            btnMyItems.Visible = !btnMyItems.Visible;
            btnMyOrders.Visible = !btnMyOrders.Visible;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            foreach (Form form in Application.OpenForms)
            {
                form.Hide();
            }
            loginForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NotificationForm notificationForm = new NotificationForm();
            notificationForm.Show();
            this.Close();
        }

        private void btnMyAccount_Click(object sender, EventArgs e)
        {
            AccountForm accountForm = new AccountForm();
            accountForm.Show();
            this.Close();
        }

        private void btnMyItems_Click(object sender, EventArgs e)
        {
            OrdersForm ordersForm = new OrdersForm();
            ordersForm.Show();
            this.Close();

        }

        private void btnMyOrders_Click(object sender, EventArgs e)
        {
            ItemsForm itemsForm = new ItemsForm();
            itemsForm.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            CartForm cartForm = new CartForm();
            foreach (Form form in Application.OpenForms)
            {
                form.Hide();
            }
            cartForm.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AccountForm accountForm = new AccountForm();
            accountForm.Show();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            NotificationForm notificationForm = new NotificationForm();
            notificationForm.Show();
            this.Close();
        }
    }
}
