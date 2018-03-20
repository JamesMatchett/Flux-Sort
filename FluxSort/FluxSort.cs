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
            List<int> UnsortedList = new List<int>();
        }

        static List<int> FluxSort(List<int> UnsortedList)
        {
            List<int> SortedList = new List<int>();
            int Lowest = 0;
            while (UnsortedList.Count != 0)
            {
                foreach (int q in UnsortedList)
                {
                    if (Lowest > q)
                    {
                        Lowest = q;
                    }
                }
                SortedList.Add(Lowest);
                UnsortedList.Remove(Lowest);
            }
            return SortedList;
        }
    }
}
