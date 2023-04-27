using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Proje.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin p)
        {
            Context c = new Context();
            var adminuserifo = c.Admins.FirstOrDefault(x => x.UserName == p.UserName && x.Password == p.Password);
            if (adminuserifo != null)
            {
                FormsAuthentication.SetAuthCookie(adminuserifo.UserName, false);
                Session["UserName"] = adminuserifo.UserName;
                return RedirectToAction("Index", "AdminCategory");
            }
            else
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}