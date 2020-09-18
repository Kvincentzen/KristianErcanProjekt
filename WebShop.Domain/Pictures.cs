using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Domain
{
    public class Pictures
    {

        public int PictureId { get; set; }
        public string Name { get; set; }
        public Product ProductId { get; set; }
    }
}
