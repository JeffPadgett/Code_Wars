using System;

namespace Code_Wars
{

   //You get an array of numbers, return the sum of all of the positives ones.

//   Example [1,-4,7,12] => 1 + 7 + 12 = 20

//   Note: if there is nothing to sum, the sum is default to 0.


    class MainClass
    {
        public int sum;
        
        public static void Main(string[] args)
        {

        }

        public static int PositiveSum(int[] arr)
        {
            //find a place to store the int
            int sum = 0;
            foreach (int number in arr)
            {
                if (number >= 0)
                    sum += number;
            }

            return sum;
        }

        //Best Practice is to use a LINQ return arr.Where(x => x > 0).Sum();
    }
}
