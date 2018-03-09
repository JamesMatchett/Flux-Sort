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
            //add some test data and run
        }
    }


    
        public class Flux_Sort
        {
            public static List<DataType> Sort(List<DataType> UnsortedList)
            {
                foreach (DataType D in UnsortedList)
                {
                    foreach (DataType P in UnsortedList)
                    {
                        if (P.Value < D.Value)
                        {
                            D.Value++;
                        }
                    }
                }

                //find max LP
                int MaxLP = 0;
                foreach (DataType T in UnsortedList)
                {
                    if (T.Value > MaxLP)
                    {
                        MaxLP = T.Value;
                    }
                }

                //sort and return new list according to listpriority (LP)
                List<DataType> sortedList = new List<DataType>();
                for (int i = 0; i <= MaxLP; i++)
                {
                    foreach (DataType E in UnsortedList)
                    {
                        if (E.Value == i)
                        {
                            sortedList.Add(E);
                        }
                    }
                }

                return sortedList;
            }
        }

        public class DataType
        {
            public int Value { get; set; }
            public int ListPriority { get; set; }

            public DataType()
            {
                ListPriority = 0;
            }

            public DataType(int _value) : this()
            {
                Value = _value;
            }
        }
    }

