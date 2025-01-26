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
    public partial class ProductRegistrationForm : Form
    {
        public ProductRegistrationForm()
        {
            InitializeComponent();
        }

        private void btnPsubmit_Click(object sender, EventArgs e)
        {
            // Retrieve and validate each field
            string productName = txtPname.Text.Trim();
            string category = cmbPcategory.SelectedValue?.ToString();
            string description = txtPdesc.Text.Trim();

            // Validate numeric fields
            if (!decimal.TryParse(txtPprice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!uint.TryParse(txtPdiscount.Text, out uint discountAmount) || discountAmount > 100)
            {
                MessageBox.Show("Please enter a valid discount percentage (0-100).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numericUpDownQuantity.Value <= 0)
            {
                MessageBox.Show("Quantity in stock must be greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numericUpDownDelivTim.Value <= 0)
            {
                MessageBox.Show("Delivery time must be greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("Product name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please provide a description for the product.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if an image is provided
            if (pbItemPhoto.Image == null)
            {
                MessageBox.Show("Please add a product image.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calculate the final price
            decimal afterPrice = price - (price * discountAmount / 100);
            uint deliveryTime = (uint)numericUpDownDelivTim.Value;
            int quantityInStock = (int)numericUpDownQuantity.Value;

            using (var context = new AppDbContext())
            {
                // Convert the image to a byte array
                byte[] photo = null;
                using (var ms = new MemoryStream())
                {
                    pbItemPhoto.Image.Save(ms, pbItemPhoto.Image.RawFormat);
                    photo = ms.ToArray();
                }

                // Create and save the new item
                var item = new Item
                {
                    Name = productName,
                    Category = category,
                    BeforePrice = price,
                    Description = description,
                    quantityInStock = quantityInStock,
                    HasDiscount = discountAmount > 0,
                    DiscountAmount = discountAmount,
                    AfterPrice = afterPrice,
                    SellerId = Session.CurrentUser.Id, // Associate the item with the logged-in user
                    PurchaseCount = 0,
                    DeliverTime = deliveryTime,
                    Photo = photo
                };

                context.Items.Add(item);
                context.SaveChanges();

                MessageBox.Show("Product successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

                MainForm main = new MainForm();
                main.Show();
            }
        }


        private void ProductRegistrationForm_Load(object sender, EventArgs e)
        {
            cmbPcategory.DataSource = Session.categories;

            // If using categories from the database
            // cmbCategories.DataSource = GetCategoriesFromDatabase();

            cmbPcategory.SelectedIndex = -1; // Optional: Set to no selection initially
        }

        private void numericUpDownDelivTim_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Display the selected photo in the PictureBox
                    pbItemPhoto.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainForm ProductRegistrationForm = new MainForm();
            foreach (Form form in Application.OpenForms)
            {
                form.Hide();
            }
            ProductRegistrationForm.Show();
        }
    }
}
