using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Article.Models
{
    public class Comment
    {
        
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public Users Users { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
