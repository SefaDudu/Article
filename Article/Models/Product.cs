using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Article.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Feature { get; set; }
        public string Photo { get; set; }
        public double UnitPrice { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
