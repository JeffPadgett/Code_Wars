using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryCodingChallenge
{
    public class Grocery
    {
        protected string name;
        protected float weight;

        protected enum GroceryType
        {
            Produce = 0,
            Meat = 1,
            Dairy = 2,
        }

    }
}
