﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Article.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public DateTime Birthday { get; set; }
        public string password { get; set; }
        public List<Address> Address { get; set; }
    }
}
