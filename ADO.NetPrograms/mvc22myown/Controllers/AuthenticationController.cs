using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc22myown.Models;
using System.Web.Security;

namespace mvc22myown.Controllers
{
    public class AuthenticationController : Controller
    {
        // GET: Authentication
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult DoLogin(UserDetail u)
        {
            StudentBusinessLayer bla=new StudentBusinessLayer();
            if(bla.IsValidUser(u))
            {
                FormsAuthentication.SetAuthCookie(u.UserName,false);
                return RedirectToAction("GetStudents", "Student");
            }
            else
            {
                ModelState.AddModelError("CredentialError", "Invalid UserName or Password");
                return View("Login");
            }
        }
    }
}