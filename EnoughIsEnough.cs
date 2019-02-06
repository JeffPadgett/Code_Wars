using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnoughIsEnough
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public class Kata
        {
            public static int[] DeleteNth(int[] arr, int x)
            {
                if (x <= 0)
                    return new int[0];
                List<int> listArr = new List<int>();
                listArr = arr.ToList();
                var newListArr = new List<int>();

                foreach (int num in listArr)
                {
                    int numCount = newListArr.Where(y => y == num).Count(); //var that determines the amount of times an elemment appears in an array.
                    if (numCount < x)
                        newListArr.Add(num);
                }
                return newListArr.ToArray();
            }
        }

    }
}
