using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingApp.Models
{
    internal class Cart
    {
        public static List<CartItem> Items { get; set; } = new List<CartItem>();
        public static decimal DeliFee { get; set; } = 50;
        public static decimal TotalPrice { get; set; } = DeliFee;
    }
}
