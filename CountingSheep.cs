using System;



/*Consider an array of sheep where some sheep may be missing from their place. 
 * We need a function that counts the number of sheep present in the array 
 * (true means present).*/


namespace Reverse_String
{


    public class CountingSheep
    {

        private static int SheepCounter(bool[] sheepArray)

        {

            int numberOfSheep = 0;
            foreach (var sheep in sheepArray)
            {
                if (sheep)
                    numberOfSheep++;
            }

            return numberOfSheep;

        }

        //Best Practice     return sheepArray.Count(s => s);



    }


}
