using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebShop.Domain;

namespace WebShopAPI.Data
{
    public class WebShopAPIContext : DbContext
    {
        public WebShopAPIContext (DbContextOptions<WebShopAPIContext> options)
            : base(options)
        {
        }

        public DbSet<WebShop.Domain.Product> Product { get; set; }

        public DbSet<WebShop.Domain.Category> Category { get; set; }

        public DbSet<WebShop.Domain.Customer> Customer { get; set; }

        public DbSet<WebShop.Domain.Order> Order { get; set; }

        public DbSet<WebShop.Domain.Variation> Variation { get; set; }

        public DbSet<WebShop.Domain.OrderDetail> OrderDetail { get; set; }
    }
}
