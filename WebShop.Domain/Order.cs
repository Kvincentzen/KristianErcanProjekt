using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Domain
{
    class Order
    {
        public int OrderId { get; set; }
        public DateTime date { get; set; }
        public Customer CustomderId { get; set; }
    }
}
