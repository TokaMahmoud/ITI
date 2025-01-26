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
    public partial class CartItemUserControl : UserControl
    {
        public CartItemUserControl()
        {
            InitializeComponent();
        }

        public Image ItemPhoto
        {
            get => pbItemPhoto.Image;
            set => pbItemPhoto.Image = value;
        }
        public string ItemName
        {
            get => lblName.Text;
            set => lblName.Text = $"{value}";
        }
        public string ItemPrice
        {
            get => lblPrice.Text;
            set => lblPrice.Text = $"Price: {value}";
        }
        public string ItemDiscount
        {
            get => lblDiscount.Text;
            set
            {
                if (decimal.TryParse(value, out decimal discountDecimal) && discountDecimal > 0)
                {
                    lblDiscount.Text = $"Discount: {discountDecimal:0.##}%"; // Show discount percentage
                    lblDiscount.Visible = true; // Make visible if there's a valid discount
                }
                else
                {
                    lblDiscount.Visible = false; // Hide the label if no discount
                }
            }
        }

        public string ItemDescription
        {
            get => lblDescription.Text;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    lblDescription.Visible = false; // Hide the label if no description
                }
                else
                {
                    lblDescription.Visible = true; // Show the label
                    lblDescription.Text = $"{value}";
                }
            }
        }

        public string ItemDeliveryTime
        {
            get => lblDeliveryTime.Text;
            set => lblDeliveryTime.Text = $"{value}";
        }

        private void btnDeleteFromCart_Click(object sender, EventArgs e)
        {
            // Notify the MainForm about the add-to-cart action
            CartForm mainForm = Application.OpenForms.OfType<CartForm>().FirstOrDefault();
            mainForm?.btnDeleteFromCart_Click(this, e);
        }
    }

}
