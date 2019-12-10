using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public static partial class Sort 
    {
        public static void InsertionSort()
        {
            int i, j;
            int size = data.Count;

            for (i = 1; i < size; i++)
            {
                int current = data[i];
                int ins = 0;

                for (j = i-1; j >= 0 && ins != 1;)
                {
                    if (data.ElementAt(j).CompareTo(current) > 0)
                    {
                        Console.WriteLine($"{data[j]} > {current} => swap element at position {j+1} with element at position {j}");
                        Insert (current, j);
                        j--;
                    }
                    else ins = 1;
                }
            }

            Console.Write("Sorted Linked List:");

            foreach (var item in data)
            {
                Console.Write(item + " ");
            }
        }

        private static void Insert (int item, int pos) 
        {
            data[pos+1] = data[pos];
            data[pos] = item;

        }
    }
}