using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using WebShop.Domain;

namespace WebShop.Data
{
    public class WebShopContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<ProductVariation> ProductVariations { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Pictures> Pictures { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Variation> Variations { get; set; }
    }
}
