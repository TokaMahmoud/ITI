using System;
using System.Windows.Forms;
using System.Xml.Linq;
using OnlineShoppingApp.Models;

namespace OnlineShoppingApp
{
    public partial class EditItemForm : Form
    {
        public Item UpdatedItem { get; private set; }

        public EditItemForm(Item item)
        {
            InitializeComponent();

            // Populate the form fields with the current item details
            txtPname.Text = item.Name;
            cmbPcategory.SelectedValue = item.Category;
            txtPprice.Text = item.AfterPrice.ToString();
            numericUpDownQuantity.Value = item.quantityInStock;
            numericUpDownDelivTim.Value = item.DeliverTime;
            txtPdiscount.Text = item.DiscountAmount.ToString();
            txtPdesc.Text = item.Description;
            if (item.Photo != null)
            {
                using (var ms = new MemoryStream(item.Photo))
                {
                    pbItemPhoto.Image = Image.FromStream(ms); // Display the photo
                }
            }
            UpdatedItem = item;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (decimal.TryParse(txtPprice.Text, out decimal price) &&
                decimal.TryParse(txtPdiscount.Text, out decimal discount))
            {
                using (var context = new AppDbContext())
                {
                    // Fetch the item from the database
                    var item = context.Items.FirstOrDefault(i => i.code == UpdatedItem.code);

                    if (item != null)
                    {
                        if (pbItemPhoto.Image != null)
                        {
                            using (var ms = new MemoryStream())
                            {
                                // Clone the image to avoid locking issues
                                using (var clonedImage = new Bitmap(pbItemPhoto.Image))
                                {
                                    // Save the cloned image to MemoryStream
                                    clonedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                                    UpdatedItem.Photo = ms.ToArray();
                                }
                            }
                        }
                        // Update item properties
                        item.Name = txtPname.Text;
                        item.Category = (string)cmbPcategory.SelectedValue;
                        item.AfterPrice = price;
                        item.quantityInStock = (int)numericUpDownQuantity.Value;
                        item.DiscountAmount = discount;
                        item.Description = txtPdesc.Text;
                        item.DeliverTime = (uint)numericUpDownDelivTim.Value;                     

                        // Save changes to the database
                        context.Items.Update(item);
                        context.SaveChanges();

                        MessageBox.Show("Item updated successfully.");
                        DialogResult = DialogResult.OK; // Indicate success
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Item not found in the database.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please check the details and try again.");
            }
        }


        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbItemPhoto.Image = Image.FromFile(openFileDialog.FileName); // Load the selected image
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; // Cancel the operation
            Close();
        }

        private void EditItemForm_Load(object sender, EventArgs e)
        {
            cmbPcategory.DataSource = Session.categories;
        }
    }
}
