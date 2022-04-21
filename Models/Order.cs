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

        public virtual ICollection<Product_Order> Product_Orders { get; set; }

        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public Order(ApplicationUser currentUser)
        {
            this.ApplicationUserId = currentUser.Id;
            this.ApplicationUser = currentUser;
            this.Id = currentUser.Orders.Count;
            this.OrderDate = DateTime.Now;
            this.IsClosed = false;
        }

        public void Add(Product product, int quantity)
        {
            Product_Orders.Add(new Product_Order
            {
                Id = Product_Orders.Count,
                Quantity = quantity,
                ProductId = product.Id,
                OrderId = this.Id,
                Product = product,
                Order = this
            });

            ApplicationUser.Orders.Add(this);//?
        }

        public void confirmOrder()
        {
            OrderDate = DateTime.Today;
            IsClosed = true;
        }
    }
}