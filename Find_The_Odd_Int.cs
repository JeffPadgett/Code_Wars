using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{

    //Directions:

    //Given an array, find the int that appears an odd number of times.
    //There will always be only one integer that appears an odd number of times.

    class Program
    {
        static void Main(string[] args)
        {
            int[] test_Array = { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 };

            find_it(test_Array);
        }

        public static int find_it(int[] seq)
        {
            string finalAnswer = ""; 
            Dictionary<string, int>  odd_Finder = new Dictionary<string, int>();
            int i = 1;
            foreach (int s in seq)
            {
                if (odd_Finder.ContainsKey(s.ToString()))
                {
                    odd_Finder[s.ToString()] += 1;
                }
                else
                odd_Finder.Add(s.ToString(),i);
            }
            foreach (KeyValuePair<string, int> s in odd_Finder)
            {
                if (s.Value % 2 == 1)
                {
                    finalAnswer = s.Key;
                }
            }
            return Convert.ToInt32(finalAnswer);
        }




        /* --------------------------------------------------Best Practices---------------------------------------------------------
        return seq.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key;
        -------------

        public static int find_it(int[] seq)
        {
            int found = 0;

            foreach (var num in seq)
            {
                found ^= num;
            }

            return found;
        }
        This is the most clever thing ever of the XOR opperator

        ----------------------------------------------------------------------------------------------------------------------------*/
    }
}
