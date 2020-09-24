using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Domain
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public Login Login { get; set; }
        public int LoginId { get; set; }
        public string FullName { get; set; }
    }
}
