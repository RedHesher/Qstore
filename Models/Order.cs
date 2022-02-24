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

        //public void addProducts(Order lastOrder)
        //{
        //    if (!currentUser.Orders.Last().IsClosed) // ApplicationUser custom methods???
        //    {
        //        lastOrder = currentUser.Orders.Last();
        //    }
        //    else
        //    {
        //        lastOrder = new Order();
        //    }

        //    for (int i = 0; i < quantity; i++)
        //        lastOrder.Products.Add(product);
        //}
    }
}