using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingApp.Models
{
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int code { get; set; } // Primary Key
        public string Name { get; set; }
        public string Description { get; set; }

        public string Category { get; set; }
        public decimal BeforePrice { get; set; }
        public decimal AfterPrice { get; set; }
        public uint DeliverTime { get; set; }   
        public decimal DiscountAmount { get; set; }
        public int PurchaseCount { get; set; }
        public int quantityInStock { get; set; }
        public bool HasDiscount { get; set; }
        public byte[] Photo { get; set; } // Store the photo as a byte array

        public int SellerId { get; set; } // Foreign key for User (Customer/Seller)
        public virtual User Seller { get; set; }
    }
}
