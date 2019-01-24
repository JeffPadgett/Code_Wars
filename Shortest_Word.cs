using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shortest_Word
{

    //Simple, given a string of words, return the length of the shortest word(s).

    //String will never be empty and you do not need to account for different data types.


    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int FindShort(string s)
        {
            
            string[] seperatedStringsArray = s.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });

            string lowestString = seperatedStringsArray[0];
            foreach (string n in seperatedStringsArray)
            {
                if (n.Length < lowestString.Length)
                {
                    lowestString = n;
                }
            }

            return lowestString.Count();
            //Best Practices
            //return s.Split(' ').Min(x => x.Length);
            // OR
            //return s.Split(' ').Min(s1 => s1.Length );
            // OR
            /*
        string[] strArr = s.Split(' ');
        int maxx = int.MaxValue;

        foreach (string item in strArr)
        {
            if (item.Length < maxx)
            {
                maxx = item.Length;
            }
        }
        return maxx;
             */



        }
    }
}
