using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{


    //This time no story, no theory.The examples below show you how to write function accum:

    //Examples:

    //accum("abcd") -> "A-Bb-Ccc-Dddd"
    //accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
    //accum("cwAt") -> "C-Ww-Aaa-Tttt"
    //The parameter of accum is a string which includes only letters from a..z and A..Z.


    class Program
    {
        static void Main(string[] args)
        {

        }

        public static String Accum(string s)
        {
            //Create a place to store the string that is to be converted.
            var convertedString = new StringBuilder();
            //itterate through every char in the string
            int i = 1;
            foreach (char c in s)
            {
                string stringToAdd = new String(c,i).ToLower();
                //for every char in string, multiply that char by i and capatalize the first letter
                //How do you multiply a char string value times its index value to be appended to a string?
                if (convertedString.Length > 1)
                convertedString.Append(stringToAdd.First().ToString().ToUpper() + stringToAdd + "-");
                else
                    convertedString.Append(stringToAdd.First().ToString().ToUpper() + "-");

                //I need to figure out how to add each char to the variable Converted String, 
                i++;
            }
            return convertedString.ToString();
            //input that value into the created variable at the beginning
            //return that variable

        }


    }
}
