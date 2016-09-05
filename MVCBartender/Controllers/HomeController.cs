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

        /*****************************************************
         * Loads as default.
         * Returns view of Drink object list.
         *****************************************************/
        public ActionResult Index()
        {   
            //return the list of drinks from the Drink model in a table
            return View(Drink.menu);
        }

    }
}