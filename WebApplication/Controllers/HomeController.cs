using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        Model1 db = new Model1();
        public ActionResult Index()
        {
            ViewBag.SaleProduct = db.Products.OrderByDescending(x => x.Discount>0).Take(4).ToList();
            List<Product> pro = db.Products.Take(8).ToList();
            return View(pro);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

    //    public ActionResult Details(int id)
    //    {   //tim pro = id
    //        Product p = db.Products.SingleOrDefault(x => x.ProductID == id);
    ////        //neu ko tim thay
    ////        if (p == null)
    ////        {
    ////            return HttpNotFound();
    ////         }
    //        return View(p);
    //}

        [ChildActionOnly]
        public ActionResult loadCategory()
        {
            List<Category> cate = db.Categories.Take(5).ToList();//Take(số lượng muốn lấy).Tolist
            return PartialView(cate);
        }

       
    }
}