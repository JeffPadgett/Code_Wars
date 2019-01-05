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

            Console.WriteLine(Accum("AZBd"));
            Console.ReadLine();

        }

        public static String Accum(string s)
        {

            var convertedString = new StringBuilder();

            int i = 1;
            char last = s.Last();
            foreach (char c in s)
            {
                string stringToAdd = new String(c, i).ToLower();

                if (convertedString.Length > 1)
                {
                    stringToAdd = stringToAdd.Remove(stringToAdd.Length - 1);
                    convertedString.Append(stringToAdd.First().ToString().ToUpper() + stringToAdd + "-");
                    if (i == s.Length)
                    {
                        convertedString.Length--;
                    }
                }
                else
                    convertedString.Append(stringToAdd.First().ToString().ToUpper() + "-");

                i++;
            }
            return convertedString.ToString();

        }
        //Best Practices : return string.Join("-",s.Select((x,i)=>char.ToUpper(x)+new string(char.ToLower(x),i)));

        //or 

       /* public static String Accum(string s)
        {
            // your code
            string result = "";
            char[] stringArray;
            stringArray = s.ToCharArray();
            for (int i = 0; i < stringArray.Length; i++)
            {
                char.ToLower(stringArray[i]);
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0)
                    {
                        result = result + char.ToUpper(stringArray[i]);
                    }
                    else
                    {
                        result = result + char.ToLower(stringArray[i]);
                    }
                }
                if (i != stringArray.Length - 1)
                {
                    result = result + '-';
                }

            }
            return result;
        }*/

    }
}
