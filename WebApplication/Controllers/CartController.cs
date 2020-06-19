using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        //public ActionResult Index()
        //{
        //    var cart = ShoppingCartcs.Cart;
        //    return View(cart.Items);
        //}

        //public ActionResult Add(int id)
        //{
        //    var cart = ShoppingCartcs.Cart;
        //    cart.Add(id);

        //    var info = new { cart.Count, cart.Total };
        //    return Json(info, JsonRequestBehavior.AllowGet);
        //}

        //public ActionResult Remove(int id)
        //{
        //    var cart = ShoppingCartcs.Cart;
        //    cart.Remove(id);

        //    var info = new { cart.Count, cart.Total };
        //    return Json(info, JsonRequestBehavior.AllowGet);
        //}

        //public ActionResult Update(int id, int quantity)
        //{
        //    var cart = ShoppingCartcs.Cart;
        //    cart.Update(id, quantity);

        //    var p = cart.Items.Single(i => i.Id == id);
        //    var info = new
        //    {
        //        cart.Count,
        //        cart.Total,
        //        Amount = p.UnitPrice * p.Quantity * (1 - p.Discount)
        //    };
        //    return Json(info, JsonRequestBehavior.AllowGet);
        //}

        //public ActionResult Clear()
        //{
        //    var cart = ShoppingCartcs.Cart;
        //    cart.Clear();
        //    return RedirectToAction("Index");
        //}
    }
}