using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingApp.Models
{

    internal class Session
    {
        public static List<string> categories = new List<string>
            {
                "Electronics",
                "Clothing",
                "Books",
                "Home & Kitchen",
                "Toys",
                "Health & Beauty",
                "Sports",
                "Automotive"
            };
        public static User? CurrentUser { get; set; } // Stores the logged-in user

    }
}
