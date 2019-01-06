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


  /*In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.

    Example:

    Kata.HighAndLow("1 2 3 4 5");  // return "5 1"
    Kata.HighAndLow("1 2 -3 4 5"); // return "5 -3"
    Kata.HighAndLow("1 9 3 4 -5"); // return "9 -5"
Notes:
All numbers are valid Int32, no need to validate them.
There will always be at least one number in the input string.
Output string must be two numbers separated by a single space, and highest number is first. */

    class Program
    {
        static void Main(string[] args)
        {


        }

        public static string HighAndLow(string numbers)
        {
            string finalString = null;
            int? minNumber = null;
            int? maxNumber = null;
            char[] splitter = {' '};
            string[] arrayOfNums = numbers.Split(splitter);
            int[] convertedArray = new int[arrayOfNums.Length];
            convertedArray = Array.ConvertAll<string, int>(arrayOfNums, int.Parse);
            minNumber = convertedArray.Min();
            maxNumber = convertedArray.Max();
            return finalString = maxNumber.ToString() + " " + minNumber.ToString();
        }

        /* --------------------------------------------------Best Practices---------------------------------------------------------
        var parsed = numbers.Split().Select(int.Parse);
        return parsed.Max() + " " + parsed.Min();

        LINQ
        var numbersList = numbers.Split(' ').Select(x => Convert.ToInt32(x));
        return string.Format("{0} {1}", numbersList.Max(), NumbersList.Min());
        */

    }
}
