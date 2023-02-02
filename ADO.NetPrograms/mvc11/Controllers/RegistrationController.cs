using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc11.Models;

namespace mvc11.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Register()
        {

            return View();
        }
        public ActionResult SaveRegister(UserDetails ud)
        { 
            EmployeeBusinessLayer ebal = new EmployeeBusinessLayer();
            ebal.Saveregister(ud);
            return RedirectToAction("Login","Authentication");
        }
    }
}