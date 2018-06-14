using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleBog.ViewModel;

namespace SimpleBog.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Login()
        {
            return View(new AuthLogin
            {
                Test = "This is my test value set in my controller!"
            });
        }


        // Post goes here
        [HttpPost]
        public ActionResult Login(AuthLogin form)
        {
            form.Test = "This is test value set in contrainer!";
            return View(form);
        }
    }
}