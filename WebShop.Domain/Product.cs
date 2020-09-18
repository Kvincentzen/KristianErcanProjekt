using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace WebShop.Domain
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public Category Category { get; set; }
    }
}
