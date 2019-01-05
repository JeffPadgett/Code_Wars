using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{

    class Program
    {
        static void Main(string[] args)
        {


        }

        public static int Opposite(int number)
        {
            //if number is positive return it as a negative, if number is negative, return it as a positive.
            return (number <=0) ? Math.Abs(number) : -Math.Abs(number);

            //Best Practices 
            //return number * -1;
            //return -number;
        }

    }
}
