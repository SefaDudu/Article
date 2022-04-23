using Article.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Article.ViewsModel
{
    public class ProfileVm
    {
        public Users Users { get; set; }
        public List<Address> Address { get; set; }
    }
}
