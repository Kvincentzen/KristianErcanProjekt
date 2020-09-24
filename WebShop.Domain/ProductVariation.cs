using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Domain
{
    public class ProductVariation
    {
        public int ProductId { get; set; }
        public int VariationId { get; set; }
        public Product Product { get; set; }
        public Variation Variation { get; set; }
        public int PrisMod { get; set; }

    }
}
