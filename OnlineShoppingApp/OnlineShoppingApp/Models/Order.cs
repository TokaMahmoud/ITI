using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingApp.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime OrderTime { get; set; }
        public string State { get; set; } // Delivered or Not Yet
        public int BuyerId { get; set; }
        public User Buyer { get; set; }
        public int SellerId { get; set; }
        public User Seller { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public string PaymentMethod { get; set; }
        public decimal totalPrice {  get; set; }
    }
}
