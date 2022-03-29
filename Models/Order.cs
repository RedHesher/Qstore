using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Qstore.Models
{
    public class Order
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public bool IsClosed { get; set; }

        public virtual ICollection<Product_Order> Product_Order { get; set; }

        public int ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public void confirmOrder()
        {
            OrderDate = DateTime.Today;
            IsClosed = true;
        }
    }
}