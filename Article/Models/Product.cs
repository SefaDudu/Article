using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Article.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
