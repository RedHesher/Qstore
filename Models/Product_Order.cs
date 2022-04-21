using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Qstore.Models
{
    public class Product_Order
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        
        [Column(Order = 1)]
        public int OrderId { get; set; }
        
        [Column(Order = 2)]
        public int ProductId { get; set; }
        

        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}