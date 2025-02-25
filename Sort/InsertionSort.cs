using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public static partial class Sort 
    {
        public static void InsertionSort()
        {
            Console.WriteLine ("InsertionSort");
            int i, j;
            int size = data.Count;

            for (i = 1; i < size; i++)
            {
                int current = data[i];
                int ins = 0;

                for (j = i-1; j >= 0 && ins != 1;)
                {
                    IncrementStepCounter();
                    PrintData("comp", j, j+1);
                    if (data.ElementAt(j).CompareTo(current) > 0)
                    {
                        IncrementStepCounter();
                        Insert (current, j);
                        PrintData("swap", j, j+1);
                        j--;
                    }
                    else ins = 1;
                }
            }
            IncrementStepCounter();
            PrintData ("exit");
        }

        private static void Insert (int item, int pos) 
        {
            data[pos+1] = data[pos];
            data[pos] = item;

        }
    }
}
