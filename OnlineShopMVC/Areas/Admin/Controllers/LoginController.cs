using Model;
using OnlineShopMVC.Areas.Admin.Code;
using OnlineShopMVC.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShopMVC.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // Dam bao dong bo chong viec request lien tuc
        public ActionResult Index(LoginModel model)
        {
            var result = new AccountModels().Login(model.UserName, model.Password);
            if(result && ModelState.IsValid) {
                SessionHelper.SetSession(new UserSession() { UserName = model.UserName });
                return RedirectToAction("Index", "Home");
            } else {
                ModelState.AddModelError("", "Ten dang nhap hoac mat khau khong dung. ");
            }
            return View(model);
        }
    }
}