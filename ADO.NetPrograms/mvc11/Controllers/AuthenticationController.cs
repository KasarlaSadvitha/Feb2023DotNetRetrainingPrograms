using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc11.Models;
using System.Web.Security;

namespace mvc11.Controllers
{
    public class AuthenticationController : Controller
    {
        // GET: Authentication
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult DoLogin(UserDetails u)
        {
            EmployeeBusinessLayer bal = new EmployeeBusinessLayer();
            if(bal.IsValidUser(u))
            {
                FormsAuthentication.SetAuthCookie(u.UserName, false);
                return RedirectToAction("GetEmployees", "Employee");
            }
            else
            {
                ModelState.AddModelError("CredentialError", "Invalid username or Password");
                return View("Login");
            }
        }
    }
}