using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Domain
{
    class Customer
    {
        public int CustomerId { get; set; }
        public Login LoginId { get; set; }
        public string FullName { get; set; }
    }
}
