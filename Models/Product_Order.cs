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

        [Key]
        [Column(Order = 1)]
        public int OrderId { get; set; }
        [Key]
        [Column(Order = 2)]
        public int ProductId { get; set; }
        

        public Order Order { get; set; }
        public Product Product { get; set; }
        
        //public bool isProductInOrder(Product product, Order order)
        //{
        //    return (product.Id == OrderId && order.Id == OrderId) ? true : false;
        //}
    }
}