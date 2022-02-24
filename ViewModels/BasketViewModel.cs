
using Qstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qstore.ViewModels
{
    public class BasketViewModel
    {
        public List<Order> Orders { get; set; }
        public List<Product> Products { get; set; }
    }
}