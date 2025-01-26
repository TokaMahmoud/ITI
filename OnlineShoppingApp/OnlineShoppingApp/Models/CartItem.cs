using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingApp.Models
{
    internal class CartItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public byte[] Photo { get; set; } // Store the photo as a byte array

        public DateTime DeliveryDate { get; set; }
    }
}
