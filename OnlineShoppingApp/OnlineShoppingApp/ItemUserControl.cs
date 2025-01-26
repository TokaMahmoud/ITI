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
    public partial class ItemUserControl : UserControl
    {
        public ItemUserControl()
        {
            InitializeComponent();
            //btnAddToCart.Click += BtnAddToCart_Click;
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
                if (decimal.TryParse(value, out decimal discountDecimal) && discountDecimal == 0)
                {
                    
                    lblDiscount.Visible = false; // Hide the label if no discount
                }
                else
                {

                    lblDiscount.Text = $"Discount: {(int)discountDecimal}%"; // Show discount percentage

                }
            }
        }



        public string ItemPurchaseCount
        {
            get => lblPurchaseCount.Text;
            set => lblPurchaseCount.Text = $"Number of purchases: {value}";
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
                    lblDescription.Text = $"Description: {value}";
                }
            }
        }
        public string ItemSellerName
        {
            get => lblSellerName.Text;
            set => lblSellerName.Text = $"Sold by: {value}"; // Set the seller's name dynamically
        }

        public string ItemDeliveryTime
        {
            get => lblDeliveryTime.Text;
            set => lblDeliveryTime.Text = $"{value}";
        }
        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            // Notify the MainForm about the add-to-cart action
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            mainForm?.btnAddToCart_Click_1(this, e);
        }

        
    }
}
