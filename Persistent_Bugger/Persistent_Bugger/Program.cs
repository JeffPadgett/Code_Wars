using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Persistent_Bugger
{

    /*Write a function, persistence, that takes in a positive parameter num and
     returns its multiplicative persistence, which is the number of times you must 
     multiply the digits in num until you reach a single digit.

    For example:

    persistence(39) == 3 // because 3*9 = 27, 2*7 = 14, 1*4=4
    // and 4 has only one digit

    persistence(999) == 4 // because 9*9*9 = 729, 7*2*9 = 126,
    // 1*2*6 = 12, and finally 1*2 = 2

    persistence(4) == 0 // because 4 is already a one-digit number*/



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Persist.Persistence(39));
            Console.ReadLine();
        }
    }

    public class Persist
    {
        public static int Persistence(long n)
        {
            int count = 0;
            if (n.ToString().Length == 1)
            {
                return count;
            }

            count = 1;
            //break up each number in the long individually.
            List<long> listofLong = new List<long>();
            while (n > 0)
            {
                listofLong.Add(n % 10);
                n = n / 10;
            }

            //First iteration of each number mult each other in list
            long calculate(List<long> seperatedNums)
            {
                long mult = 1;
                for (int i = 0; i < seperatedNums.Count; i++)
                    mult *= seperatedNums[i];
                return (int)mult;//barely broken
            }


            do
            {
                calculate(listofLong);
                count++;
            } while ((Math.Floor(Math.Log10(n)) + 1) > 1);//broken

            return count;
        }
    }
}
