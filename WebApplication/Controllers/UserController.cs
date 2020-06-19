using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;
using System.Data.Entity.Validation;

namespace WebApplication.Controllers
{
    public class UserController : Controller
    {
        Model1 db = new Model1();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        
        public ActionResult Register(RegisterModel user)
        {
            //string tmp = user.email;
            if (ModelState.IsValid)
            {
                //UserManager userManager = new UserManager();
                //if (userManager.CheckEmail(user.Email) == false && userManager.CheckUserName(user.Username) == false)
                var check = db.Users.FirstOrDefault(m => m.Email == user.Email && m.Phone == user.Phone);
                if (check == null)
                {
                    User userDB = new User();
                    userDB.Account = user.Username;
                    userDB.Email = user.Email;
                    userDB.Phone = user.Phone;
                    userDB.Password = GetMD5(user.Password);
                    userDB.ConfirmPassword = GetMD5(user.ConfirmPassword);
                    userDB.Address = user.Address;
                    db.Users.Add(userDB);
                    db.SaveChanges();
                    return RedirectToAction("Login", "User");
                }
                else
                {
                    ModelState.AddModelError("Register","Email or Phone is duplicate");
                }
            }
            return View();
        }
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Login(RegisterModel user)
        {
            UserManager userManager = new UserManager();
            if (ModelState.IsValid)
            {
                var f_password = GetMD5(user.Password);
                var data = db.Users.Where(s => s.Email.Equals(user.Email) && s.Password.Equals(f_password)).ToList();
                if (data.Count() > 0)
                {
                    Session["user"] = data.FirstOrDefault().Email;
                    return RedirectToAction("Index", "Home");
                }
                 else
                {
                    ModelState.AddModelError("Login", "Login faile");
                }

            }
            return View();
        }

        public static string GetMD5(string str)
        {

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            byte[] bHash = md5.ComputeHash(Encoding.UTF8.GetBytes(str));

            StringBuilder sbHash = new StringBuilder();

            foreach (byte b in bHash)
            {

                sbHash.Append(String.Format("{0:x2}", b));

            }

            return sbHash.ToString();

        }

        public ActionResult Logout()
        {

            Session.Clear();//remove session
            return RedirectToAction("Index","Home");
            //Session["user"] = null;
            //return RedirectToAction("Login");
        }

    }
}