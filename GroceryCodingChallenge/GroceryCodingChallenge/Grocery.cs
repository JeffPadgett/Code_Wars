using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryCodingChallenge
{

    public enum GroceryType
    {
        Produce = 0,
        Meat = 1,
        Dairy = 2,
        General = 3,
    }

    public class GroceryItem
    {
        public float weight;
        public GroceryType type;


        public GroceryItem(float w, GroceryType t)
        {
           weight = w;
           type = t;
        }

    }
}
