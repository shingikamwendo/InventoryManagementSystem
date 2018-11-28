using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using InventoryManagementSystem.Models;
using System.Web.Security;

namespace InventoryManagementSystem.Controllers
{
    public class UserController : Controller
    {
        private InventoryDbContext db = new InventoryDbContext();
        public ActionResult Index()
        {
            var list = db.Users.ToList();
            ViewBag.UserList = list.Count();
            return View(list);
        }
 
        public ActionResult Login()
        { 
            return View();
        }
        [HttpPost]
        public ActionResult Login(User u)
        {
            string pass = FormsAuthentication.HashPasswordForStoringInConfigFile(u.Password, "SHA1");
            if(ModelState.IsValid)
            {
                u.Password = pass;
                var user = db.Users.Where(x => x.UserName == u.UserName && x.Password == u.Password && x.IsActive=="Yes").Count();
                if (user == 0)
                {
                    ViewBag.forgot= "forgot password?";
                    ViewBag.msg = "Username and/or password not match.";
                    return View();
                }
                else
                {
                    FormsAuthentication.SetAuthCookie(u.UserName, false);
                    return RedirectToAction("Index", "Home");
                }
              
            }
            return View();
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
        [Authorize(Roles="Admin,Manager")]
        public ActionResult Create()
        {
            ViewBag.EmployeeId = new SelectList(db.Employees, "EmployeeId", "EmployeeName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(User u)
        {
            string pass = FormsAuthentication.HashPasswordForStoringInConfigFile(u.Password, "SHA1");
            if(ModelState.IsValid)
            {
                u.Password = pass;
                db.Users.Add(u);          
                db.SaveChanges();             
                return RedirectToAction("Index");
            }
            return View();
        }

        public JsonResult CheckUserName(string username) 
        {
            InventoryDbContext usr = new InventoryDbContext();
            bool result = !usr.Users.ToList().Exists(model => model.UserName.Equals(username, StringComparison.CurrentCultureIgnoreCase));
            return Json(result);
        }
	}
}