using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBartender.Controllers;
using MVCBartender.Models;

namespace MVCBartender.Controllers
{
    public class PreparedController : Controller
    {
        //new list of drink objects
        public static List<Drink> servableDrinks = new List<Drink>();


        /***********************************************
         * Called by Queue.
         * Passed single selected drink object.  
         * Adds drink object to list of drink objects.
         * Removes drink object from Queue list.
         * Returns view of object list.
         ***********************************************/
        // GET: Prepared
        public ActionResult Servable(Drink drink)
        {
            //Add single selected drink object from Queue.cshtml list to Prepared.cshtml list (servableDrinks).
            servableDrinks.Add(drink);

            //Remove single selected drink object from Queue list.
            var removeDrink = OrderController.selectedDrinks.Where(listed => listed.Id == drink.Id);
            OrderController.selectedDrinks.Remove(removeDrink.FirstOrDefault());

            //Group(numerical order) drinks by table so server picks up all drinks for a certain table in one trip
            var orderByTable = servableDrinks.OrderBy(p => p.TableNum);

            //Return view of drinks ready to be served.  Must call same plain method used by Layout.
            return RedirectToAction("DrinkQueue", "Order");
        }           


        /****************************************************
         * Called by Layout.
         * Returns view with list of prepared drink objects.
         ****************************************************/
        // GET: Prepared
        public ActionResult ServeDrinks()
        {
            //Group drinks by table so server picks up all drinks for a table in one trip
            var orderByTable = servableDrinks.OrderBy(p => p.TableNum);

            return View("PreparedDrinks", orderByTable);
        }
    }
}