using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Domain
{
    public class Picture
    {

        public int PictureId { get; set; }
        public string Name { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
