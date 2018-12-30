using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ConsoleApp7
{
    class Program
    {
        //Instructions:

        //Write a function that takes a single string (word) as argument.The function must return 
        //an ordered list containing the indexes of all capital letters in the string.

        public static int[] Capitals(string word)
        {

            List<int> CapList = new List<int>();
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsUpper(word[i]))
                    CapList.Add(i);
            }

            return CapList.ToArray();
        }

    }
}
