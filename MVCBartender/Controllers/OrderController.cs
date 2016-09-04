using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBartender.Models;

namespace MVCBartender.Controllers
{
    public class OrderController : Controller
    {
        //id for drink object
        private static int id = 0;

        //new list of drink objects
        public static List<Drink> selectedDrinks = new List<Drink>();
        

        /*****************************************************
         * Called by Index.
         * Passed single selected drink object.  
         * Adds randomized table number int to drink object.   
         * Adds drink object to list of drink objects. 
         * Returns view of object list.
         *****************************************************/
        // GET: Order
         public ActionResult Queue(Drink drink)  
         {
            //Randomize the table number as though each order comes from a different table
            Random rnd = new Random();
            
            //Assign unique id to drink so can be worked with (removed) - per Adrian rather than FindIndex for remove
            drink.Id = ++id;
              
            //Assign table number to order
            drink.TableNum = rnd.Next(1, 23);
            
            //Get and add the time drink was ordered
            DateTime timestamp = DateTime.Now;
            drink.OrderTime = timestamp.ToString("T");
 
            //Add drink to order list
            selectedDrinks.Add(drink);

            //ViewBag.DrinkName = drink.DrinkName;
            //ViewBag.DrinkCost = drink.DrinkCost;
            TempData["success"] = "Thanks for your Order!";

            //Show the view with the selected drinks listed (Queue page)
            return RedirectToAction("Index", "Home");   
        }


        /****************************************************
         * Called by Layout.
         * Returns view with list of selected drink objects.
         ****************************************************/
         // GET: Order
         public ActionResult DrinkQueue()
        {
            //Show the view with the selected drinks listed (Queue page)
            return View("Queue", selectedDrinks);
        }
    }
}
