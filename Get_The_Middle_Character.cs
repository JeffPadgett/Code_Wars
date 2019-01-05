using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{


    //You are going to be given a word.Your job is to return the middle character of the word. If the word's length is odd, return the middle character. If the word's length is even, return the middle 2 characters.

//#Examples:

    //Kata.getMiddle("test") should return "es"

    //Kata.getMiddle("testing") should return "t"

    //Kata.getMiddle("middle") should return "dd"

    //Kata.getMiddle("A") should return "A"

    class Program
    {
        static void Main(string[] args)
        {


        }

        public static string GetMiddle(string s)
        {

            if (s.Length % 2 == 0)
            {
                string middleCount = s.Substring((s.Length / 2) - 1, 2);
                return middleCount;
            }
            else
            {
                string middleCount = s.Substring((s.Length / 2), 1);
                return middleCount;
            }
        }

    }
}
