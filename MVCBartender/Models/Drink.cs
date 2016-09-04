using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBartender.Models
{
    public class Drink
    {   
        [Key]
        public string DrinkName { get; set; }

        [DataType(DataType.Currency)]
        public double DrinkCost { get; set; }

        public string DrinkDescription { get; set; }

        public int Id { get; set; }

        public static List<Drink> menu = new List<Drink>
            {
                new Drink { DrinkName= "Snake in the Grass", DrinkCost=11.99, DrinkDescription="Tanqueray gin, coconut water, makrut lime leaf"},
                new Drink { DrinkName= "Even Keel", DrinkCost=9.99, DrinkDescription="Bimini gin, chili-infused tequila, aloe water"},
                new Drink { DrinkName= "Lost City", DrinkCost=11.99, DrinkDescription="Kumquats, tequila, ginger"},
                new Drink { DrinkName= "Painted Veil", DrinkCost=13.99, DrinkDescription="Scottish toffee, pu-ehr tea, Beefeater gin, Hong Kong Baijiu"},
                new Drink { DrinkName= "Wayward Traveler", DrinkCost=10.99, DrinkDescription="Coconut cream, pineapple, matcha tea"},
                new Drink { DrinkName= "Light & Stormy", DrinkCost=5.99, DrinkDescription="Tequila, ginger beer"}
            };

        public int TableNum { get; set; }

        public string OrderTime { get; set; }
    }
}