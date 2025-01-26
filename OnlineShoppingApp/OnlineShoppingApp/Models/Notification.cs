using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingApp.Models
{
    internal class Notification
    {
        public int Id { get; set; }
        public int SellerId { get; set; } // Foreign key to the seller
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
        public bool IsRead { get; set; } = false; // To track if the notification is read
    }
}
