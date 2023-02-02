using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc22myown.Models;

namespace mvc22myown.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Register()
        {
            return View("RegisterView");
        }

        public ActionResult SaveRegistrationDetails(UserDetail u)
        {
            // Put validation Inside Form
            StudentBusinessLayer bla=new StudentBusinessLayer();
            bla.SaveUserDetails(u);
            return RedirectToAction("Login", "Authentication");

        }
    }
}