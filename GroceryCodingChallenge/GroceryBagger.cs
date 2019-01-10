using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryCodingChallenge
{
    public class GroceryBagger
    {
        public int BagCount (List<GroceryItem> GList)
        {
            //create a function that adds each type in its own seperate bag, and if the list(bag)
            //exceeds 7 pounds in weight, create a new bag.
            float bags = 0f;
            float weightInProduce = 0f;
            float weightInMeat = 0f;
            float weightInGeneral = 0f;
            float weightInDairy = 0f;
            List<float> weightCatagory = new List<float>()
            {
                weightInDairy, weightInMeat, weightInGeneral, weightInProduce
            };

            foreach (GroceryItem g in GList)
            {
                //find out which type of grocery it is and which weight in catagory.
                if (g.type == GroceryType.Produce)                
                    weightCatagory[3] += g.weight;         
                if (g.type == GroceryType.Meat)                
                    weightCatagory[1] += g.weight;               
                if (g.type == GroceryType.General)                
                    weightCatagory[2] += g.weight;               
                if (g.type == GroceryType.Dairy)              
                    weightCatagory[0] += g.weight;              
            }

            /*find out the weight of each catagory and divide it by 7, add a bag for each sum
             and the remainder.*/
            foreach (float w in weightCatagory)
            {
                float tempSum;
                tempSum = w / 7f;
                bags += tempSum;
                bags = (int)Math.Ceiling(bags);

            }

            return (int)bags;
        }
    }
}
