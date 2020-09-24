using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Domain
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int Price { get; set; }
        public string Text { get; set; }
        public int Amount { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }

    }
}
