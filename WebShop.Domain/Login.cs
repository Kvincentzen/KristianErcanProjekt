using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Domain
{
    public class Login
    {
        public int LoginId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
    }
}
