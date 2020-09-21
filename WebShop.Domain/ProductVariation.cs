using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Domain
{
    public class ProductVariation
    {
        public Product ProductId { get; set; }
        public Variation VariationId { get; set; }
        public int PrisMod { get; set; }

    }
}
