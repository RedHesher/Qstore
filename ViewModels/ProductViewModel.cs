using Qstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qstore.ViewModels
{
    public class ProductViewModel
    {
        public Product product { get; set; }
        public int quantity { get; set; }
    }
}