using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Article
{
    public class Login
    {
        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("password")]
        public string password { get; set; }
    }
}
