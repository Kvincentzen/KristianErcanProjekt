using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Domain
{
    class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int Price { get; set; }
        public string Text { get; set; }
        public int Amount { get; set; }
        public Product ProductId { get; set; }
        public Order OrderId { get; set; }

    }
}
