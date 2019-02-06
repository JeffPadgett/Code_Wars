using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Filtering
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> newList = new List<object> {"cool", 3, "six", 4, "I hope I dont get fired", 19};
            List<int> practiceList = new List<int>();
            practiceList = ListFilterer.GetIntegersFromList(newList).ToList();
            practiceList.ForEach(i => Console.WriteLine("{0}\t", i));
            Console.ReadLine();
        }

        public class ListFilterer
        {
            public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
            {
                //create a place to store the new list
                List<int> numList = new List<int>();

                foreach (object item in listOfItems)
                {
                    if (item.GetType() == typeof(int))
                    {
                        int newItem = Convert.ToInt32(item);
                        numList.Add(newItem);
                    }
                }

                return numList;

                //Best Practice
                //return listOfItems.OfType<int>(); 
            }
        }
    }
}
