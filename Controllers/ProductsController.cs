using Qstore.Models;
using Qstore.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using static System.Net.WebRequestMethods;

namespace Qstore.Controllers
{
    public class ProductsController : Controller
    {
        private ApplicationDbContext _context;

        public ProductsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var productsSet = _context.Products.ToList();

            return View(productsSet);
        }

        //Products/Id
        public ActionResult Product(int id)
        {
            ProductViewModel model = new ProductViewModel();
            model.product = _context.Products.SingleOrDefault(c => c.Id == id);

            if (model.product == null)
                return HttpNotFound();

            return View(model);
        }
    }
}