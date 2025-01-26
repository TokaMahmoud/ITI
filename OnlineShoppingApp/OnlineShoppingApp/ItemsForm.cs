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
    public partial class ItemsForm : Form
    {
        private void LoadItemsForSale()
        {
            using (var context = new AppDbContext())
            {
                var items = context.Items
                    .Where(i => i.SellerId == Session.CurrentUser.Id)
                    .Select(i => new
                    {
                        Code = i.code,
                        i.Name,
                        i.Category,
                        i.AfterPrice,
                        i.quantityInStock,
                        i.DiscountAmount
                    })
                    .ToList();

                dgvItemsForSale.DataSource = items;
            }
        }
        public ItemsForm()
        {
            InitializeComponent();
            LoadItemsForSale();
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            if (dgvItemsForSale.SelectedRows.Count > 0)
            {
                // Retrieve the selected item's details
                var selectedItem = dgvItemsForSale.SelectedRows[0].DataBoundItem as dynamic;

                using (var context = new AppDbContext())
                {
                    var item = context.Items.Find(selectedItem.Code);

                    if (item != null)
                    {
                        // Open a dialog or form to edit item details
                        using (var editItemForm = new EditItemForm(item))
                        {
                            var dialogResult = editItemForm.ShowDialog();

                            if (dialogResult == DialogResult.OK)
                            {
                                /*// Update the item's details
                                context.Items.Update(editItemForm.UpdatedItem);
                                context.SaveChanges();

                                MessageBox.Show("Item details updated successfully!");*/
                                LoadItemsForSale(); // Refresh the item list
                            }
                        }
                    }
                }
            }
        }
        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvItemsForSale.SelectedRows.Count > 0)
            {
                var selectedItem = dgvItemsForSale.SelectedRows[0].DataBoundItem as dynamic;

                using (var context = new AppDbContext())
                {
                    var item = context.Items.Find(selectedItem.Code);
                    if (item != null)
                    {
                        context.Items.Remove(item);
                        context.SaveChanges();

                        MessageBox.Show("Item has been deleted from sale.");
                        LoadItemsForSale();
                    }
                }
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {

            var mainForm = new MainForm();
            mainForm.Show(); // Show the main form
            this.Close();    // Close the current form
        }
    }
}
