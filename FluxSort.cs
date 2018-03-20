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
            Random r = new Random();
            int Elements = 40000;
            for (int i = 0; i < Elements; i++)
            {  
                UnsortedList.Add(r.Next(0, 10000));
            }
            DateTime Start = DateTime.Now;
            List<int> sortedList = FluxSort(UnsortedList);
            DateTime Stop = DateTime.Now;

            foreach (int q in sortedList)
            {
                Console.WriteLine(q);

            }
            Console.WriteLine("Time taken is " + Stop.Subtract(Start).TotalSeconds + " Seconds for " + Elements +" Elements");
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
