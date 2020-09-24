using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using WebShop.Domain;

namespace WebShop.Data
{
    public class WebShopContext :DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<ProductVariation> ProductVariation { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Picture> Picture { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Variation> Variation { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<ProductVariation>().HasKey(s => new { s.ProductId, s.VariationId });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer(
                "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = WebShopAppData");
        }
    }


}
