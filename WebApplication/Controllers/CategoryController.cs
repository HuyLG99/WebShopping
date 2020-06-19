using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class CategoryController : Controller
    {
        Model1 db = new Model1();
        // GET: Product
        public ActionResult Index()
        {
            return View();
            
        }

        public ActionResult DetailProduct(int id)
        {
            Product Product = db.Products.Where(p => p.Id == id).SingleOrDefault();
            return View(Product);
        }

        [ChildActionOnly]
        public ActionResult loadCategory()
        {
            List<Category> cate = db.Categories.ToList<Category>();
            return PartialView(cate);
        }

        public ActionResult CateList(int id)
        {
            List<Product> listpro = db.Products.Where(p => p.Id == id).ToList();
            return View(listpro);
        }
        public ActionResult Saleoff()
        {
            var model = db.Products.Where(p => p.Discount > 0).OrderBy(p => Guid.NewGuid()).Take(3);
            return PartialView("Saleoff", model);
        }

        public ActionResult Special()
        {
            var model = db.Products.Where(p => p.Discount > 30);
            return PartialView("Saleoff", model);
        }
    }
}