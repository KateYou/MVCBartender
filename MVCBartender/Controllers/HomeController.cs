using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using MVCBartender.Models;

namespace MVCBartender.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View(Drink.menu);
        }

    }
}