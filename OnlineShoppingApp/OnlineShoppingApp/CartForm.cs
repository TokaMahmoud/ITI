using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using OnlineShoppingApp.Models;

namespace OnlineShoppingApp
{
    public partial class CartForm : Form
    {
        public CartForm()
        {
            InitializeComponent();
        }

        private void labDeliFee_Click(object sender, EventArgs e)
        {

        }
        private void RefreshCart()
        {
            // Clear existing controls
            flpCartItems.Controls.Clear();

            // Bind the updated cart items
            lblDeliFee.Text = $"{Cart.DeliFee:C}";
            lblTotalPrice.Text = $"{Cart.TotalPrice:C}";

            foreach (var cartItem in Cart.Items)
            {
                // Create an instance of ItemUserControl
                var itemControl = new CartItemUserControl
                {
                    ItemPhoto = cartItem.Photo != null && cartItem.Photo.Length > 0 ? Image.FromStream(new MemoryStream(cartItem.Photo)) : null,
                    ItemName = cartItem.Name,
                    ItemDescription = cartItem.Description,
                    ItemPrice = cartItem.Price.ToString("C"),
                    //ItemSellerName = cartItem, // Set seller name if applicable
                    //ItemPurchaseCount = cartItem.PurchaseCount.ToString(),
                    //ItemDiscount = cartItem.DiscountAmount > 0 ? cartItem.DiscountAmount.ToString() : null, // Show discount if available
                    ItemDeliveryTime = cartItem.DeliveryDate.ToString("yyyy-MM-dd")
                };

                // Add the item control to the FlowLayoutPanel
                flpCartItems.Controls.Add(itemControl);
            }
        }


        private void CartForm_Load(object sender, EventArgs e)
        {
            RefreshCart();
            // Populate payment method ComboBox
            cmbPaymentMethod.Items.Add("Visa");
            cmbPaymentMethod.Items.Add("Cash");
            cmbPaymentMethod.SelectedIndex = 0; // Default selection
        }

        public void btnDeleteFromCart_Click(object sender, EventArgs e)
        {
            // Ensure the sender is a button inside the CartItemUserControl
            if (sender is CartItemUserControl itemControl)
            {
                // Get the CartItemUserControl that contains the delete button

                // Find the CartItem associated with this control
                var cartItem = Cart.Items.FirstOrDefault(item => item.Name == itemControl.ItemName);

                if (cartItem != null)
                {
                    // Deduct the item's price from the total price
                    Cart.TotalPrice -= cartItem.Price;

                    // Remove the item from the Cart
                    Cart.Items.Remove(cartItem);

                    // Remove the CartItemUserControl from the FlowLayoutPanel
                    flpCartItems.Controls.Remove(itemControl);

                    // Optional: Update the total price label
                    lblTotalPrice.Text = $"{Cart.TotalPrice:C}";

                    MessageBox.Show($"Item '{cartItem.Name}' removed from the cart.");
                }
                else
                {
                    MessageBox.Show("Unable to remove the item from the cart. Please try again.");
                }

            }
            else
            {
                MessageBox.Show("Unable to remove the item. Please try again.");
            }
        }

        private void btnCancelCart_Click(object sender, EventArgs e)
        {
            // Confirm the action with the user
            var result = MessageBox.Show("Are you sure you want to cancel and clear the cart?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Clear the cart
                Cart.Items.Clear();
                Cart.TotalPrice = 0;

                // Close the CartForm and return to the main form
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Close();
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (!Cart.Items.Any())
            {
                MessageBox.Show("Your cart is empty. Add items to proceed.");
                return;
            }

            // Get the selected payment method
            string selectedPaymentMethod = cmbPaymentMethod.SelectedItem.ToString();

            if (selectedPaymentMethod == "Visa")
            {
                // Confirm Visa payment
                string visaNumber = Session.CurrentUser.VisaCardNumber;
                if (string.IsNullOrEmpty(visaNumber))
                {
                    MessageBox.Show("No Visa number found. Please add your Visa information.");
                    return;
                }

                MessageBox.Show($"You will withdraw {Cart.TotalPrice:C} using Visa: {visaNumber}");
            }
            else if (selectedPaymentMethod == "Cash")
            {
                MessageBox.Show("You selected Cash on Delivery.");
            }

            using (var context = new AppDbContext())
            {
                // Create a new Order
                var order = new Order
                {
                    OrderTime = DateTime.Now,
                    State = "Not Yet Delivered",
                    BuyerId = Session.CurrentUser.Id, // Replace with logic to get the logged-in user's ID
                    PaymentMethod = selectedPaymentMethod, // Save the payment method
                    totalPrice = Cart.TotalPrice,
                };

                // Add order items and update inventory
                foreach (var cartItem in Cart.Items)
                {
                    var item = context.Items.FirstOrDefault(i => i.Name == cartItem.Name);
                    if (item != null)
                    {
                        order.Items.Add(new OrderItem
                        {
                            ItemId = item.code,
                            Quantity = 1, // Assume quantity is always 1 for simplicity
                            DeliveryDate = DateTime.Now.AddDays((int)item.DeliverTime),
                        });

                        // Update item details
                        item.PurchaseCount++;
                        item.quantityInStock--;

                        // Set the SellerId for the order
                        order.SellerId = item.SellerId;
                    }
                }

                // Save the order to the database
                context.Orders.Add(order);
                context.SaveChanges();

                MessageBox.Show("Checkout successful. Your order has been placed!");

                //Notify seller
                foreach (var cartItem in Cart.Items)
                {
                    var item = context.Items.Include(i => i.Seller).FirstOrDefault(i => i.Name == cartItem.Name);

                    if (item != null)
                    {
                        var notification = new Notification
                        {
                            SellerId = item.SellerId,
                            Message = $"New order request for your item '{item.Name}'.\n" +
                            $"From: {Session.CurrentUser.UserName}." +
                            $"\nUser Phone Number: {Session.CurrentUser.Phone}" +
                            $"\nUser Email: {Session.CurrentUser.Email}",
                            Timestamp = DateTime.Now,
                            IsRead = false
                        };

                        context.notifications.Add(notification);
                        context.SaveChanges();

                    }
                }
                // Clear the cart
                Cart.Items.Clear();
                Cart.TotalPrice = 0;
                lblTotalPrice.Text = $"{Cart.TotalPrice:C}";
                RefreshCart();

                

            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            // Navigate back to MainForm
            var mainForm = new MainForm();
            mainForm.Show(); // Show the main form
            this.Close();    // Close the current form
        }
    }
}
