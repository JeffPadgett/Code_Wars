using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GroceryCodingChallenge
{
    class Program
    {
        /*You are a grocery bagger at a grocery store. The store just enacted a new policy in which every bag
         can only hold one type of grocery item (produce, meat, dairy, ect).
         Every bag has a max weight of 7 pounds
         
         The challenge is this: Create a collection of 20 or more grocery items and at least 3 different
         types, which vary in weight. Then create function that calculates how many bags will be needed
         in order to complete the bagging.  
        */

        static void Main(string[] args)
        {
            var chickenBreast = new GroceryItem(2.3f, GroceryType.Meat);
            var milk = new GroceryItem(1.5f,GroceryType.Dairy);
            var cheese = new GroceryItem(.4f,GroceryType.Dairy);
            var yogert = new GroceryItem(2.3f,GroceryType.Dairy);
            var cheeseSticks = new GroceryItem(2.3f,GroceryType.Dairy);
            var meatballs = new GroceryItem(3f,GroceryType.Meat);
            var tums = new GroceryItem(.1f,GroceryType.General);
            var dogFood = new GroceryItem(6f,GroceryType.General);
            var fishFood = new GroceryItem(0.1f,GroceryType.General);
            var salt = new GroceryItem(0.3f,GroceryType.General);
            var pepper = new GroceryItem(0.3f, GroceryType.General);
            var salmon = new GroceryItem(3f,GroceryType.Meat);
            var peanutButter = new GroceryItem(0.8f,GroceryType.General);
            var oranges = new GroceryItem(0.7f,GroceryType.Produce);
            var onion = new GroceryItem(0.6f,GroceryType.Produce);
            var frozenPizza = new GroceryItem(1.6f,GroceryType.Dairy);
            var avocado = new GroceryItem(0.3f, GroceryType.Produce);
            var banana = new GroceryItem(0.7f,GroceryType.Produce);
            var broccoli = new GroceryItem(0.4f,GroceryType.Produce);
            var almonds = new GroceryItem(0.2f,GroceryType.Produce);

            List<GroceryItem> groceries = new List<GroceryItem>
            {
                chickenBreast, milk, cheese, yogert, cheeseSticks, meatballs, tums, dogFood, fishFood,
                salt, pepper, salmon, peanutButter, oranges, onion, frozenPizza, avocado, banana,
                broccoli, almonds
            };

            GroceryBagger tori = new GroceryBagger();
            Console.WriteLine(tori.BagCount(groceries));
            Console.ReadLine();


        }
    }
}
