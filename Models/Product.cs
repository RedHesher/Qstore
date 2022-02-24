using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Qstore.Models
{
    public class Product
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        public Category Category { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string ImagePath { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Product_Order> Product_Order { get; set; }
    }
}