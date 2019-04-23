using HRMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRMS.Controllers
{
    public class AppController : Controller
    {
        // GET: App
        public ActionResult Login(UserLoginModel UserLoginModel)
        {
            if (UserLoginModel == null) {
                UserLoginModel = new UserLoginModel();
            }
            else {
                if (ModelState.IsValid) { }
                else View(UserLoginModel);
            }
            return View();
        }
    }
}