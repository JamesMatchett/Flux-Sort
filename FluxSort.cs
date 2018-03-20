using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> UnsortedList = new List<int>(){5,4,2,4,2,2};
            List<int> sortedList = FluxSort(UnsortedList);
            foreach (int q in sortedList)
            {
                Console.WriteLine(sortedList);

            }
            Console.ReadKey();
        }

        static List<int> FluxSort(List<int> UnsortedList)
        {
            List<int> SortedList = new List<int>();
            
            while (UnsortedList.Count != 0)
            {
                int Lowest = UnsortedList.Min();
                SortedList.Add(Lowest);
                UnsortedList.Remove(Lowest);
                
            }
            return SortedList;
        }
    }
}
