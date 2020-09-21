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
    }
}
