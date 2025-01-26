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
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
            LoadUserOrders();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {

        }
        private void UpdateOrderStates()
        {
            using (var context = new AppDbContext())
            {
                // Get today's date
                DateTime today = DateTime.Today;

                // Retrieve all orders where the state is not already "Delivered"
                var ordersToUpdate = context.Orders
                    .Where(order => order.State != "Delivered")
                    .Include(order => order.Items) // Include associated order items
                    .ToList();

                foreach (var order in ordersToUpdate)
                {
                    // Check if all delivery dates for the order's items are less than or equal to today
                    bool allItemsDelivered = order.Items.All(item => item.DeliveryDate.Date <= today);

                    if (allItemsDelivered)
                    {
                        // Update the order state to "Delivered"
                        order.State = "Delivered";
                    }
                }

                // Save changes to the database
                context.SaveChanges();
            }
        }
        private void LoadUserOrders()
        {
            UpdateOrderStates();
            using (var context = new AppDbContext())
            {
                var orders = context.Orders
                    .Where(o => o.BuyerId == Session.CurrentUser.Id)
                    .Select(o => new
                    {
                        Code = o.Id,
                        o.OrderTime,
                        o.State,
                        SellerName = o.Seller.UserName,
                        SellerEmail = o.Seller.Email,
                        Items = o.Items.Select(i => i.Item.Name).ToList(),
                        o.PaymentMethod,
                        OrderTotal = o.totalPrice + Cart.DeliFee,
                    })
                    .ToList();

                dgvUserOrders.DataSource = orders;
            }
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            if (dgvUserOrders.SelectedRows.Count > 0)
            {
                var selectedOrder = dgvUserOrders.SelectedRows[0].DataBoundItem as dynamic;

                using (var context = new AppDbContext())
                {
                    // Convert dynamic to the appropriate type (e.g., int or string, based on your Order.Id type)
                    int selectedOrderId = (int)selectedOrder.Code;

                    var order = context.Orders
                        .Include(o => o.Items) // Include related order items
                        .ThenInclude(oi => oi.Item) // Include the actual items
                        .FirstOrDefault(o => o.Id == selectedOrderId);

                    if (order != null && order.State == "Not Yet Delivered")
                    {
                        foreach (var orderItem in order.Items)
                        {
                            var item = context.Items.Find(orderItem.ItemId);
                            if (item != null)
                            {
                                item.quantityInStock += 1;
                                item.PurchaseCount -= 1;
                                context.Items.Update(item);
                            }
                        }

                        context.Orders.Remove(order); // Remove the order
                        context.SaveChanges(); // Save all changes to the database

                        MessageBox.Show("Order has been canceled.");
                        LoadUserOrders(); // Refresh the orders list

                        //Notify Seller
                        foreach (var orderItem in order.Items)
                        {
                            var item = context.Items.Include(i => i.Seller).FirstOrDefault(i => i.Name == orderItem.Item.Name);

                            if (item != null)
                            {
                                var notification = new Notification
                                {
                                    SellerId = item.SellerId,
                                    Message = $"Order From: {Session.CurrentUser.UserName}\n" +
                                    $"for your item '{item.Name}' has been canceled." +
                                    $"\nUser Phone Number: {Session.CurrentUser.Phone}" +
                                    $"\nUser Email: {Session.CurrentUser.Email}",
                                    Timestamp = DateTime.Now,
                                    IsRead = false
                                };

                                context.notifications.Add(notification);
                            }
                        }

                        context.SaveChanges();
                    }

                    else
                    {
                        MessageBox.Show("Order cannot be canceled.");
                    }
                }
            }
            else
            {
                MessageBox.Show("No order selected.");
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show(); // Show the main form
            this.Close();    // Close the current form
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (dgvUserOrders.SelectedRows.Count > 0)
            {
                var selectedOrder = dgvUserOrders.SelectedRows[0].DataBoundItem as dynamic;
                int orderId = selectedOrder.Code;

                using (var context = new AppDbContext())
                {
                    // Get the selected order with its items and the related item details
                    var order = context.Orders
                        .Include(o => o.Items)  // Include the related OrderItems
                        .ThenInclude(oi => oi.Item)  // Include the related Item for each OrderItem
                        .FirstOrDefault(o => o.Id == orderId);

                    if (order != null)
                    {
                        // Populate the DataGridView with order details (items)
                        dgvOrderItems.DataSource = order.Items
                            .Where(i => i.Item != null)  // Make sure Item is not null
                            .Select(i => new
                            {
                                ItemName = i.Item.Name,
                                Quantity = i.Quantity,
                                Price = i.Item.AfterPrice,
                                TotalPrice = i.Quantity * i.Item.AfterPrice
                            })
                            .ToList();
                    }
                    else
                    {
                        MessageBox.Show("Order not found.");
                    }
                }
            }

            else
            {
                MessageBox.Show("Please select an order to view its details.");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
