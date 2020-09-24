using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Domain
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime date { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}
