using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public static partial class Sort 
    {
        public static void BubbleSort()
        {
            int i, j;
            int size = data.Count;

            for (i = 0; i < size; i++)
            {
                for (j = 0; j < size - 1; j++)
                {
                    if (data.ElementAt(j).CompareTo(data.ElementAt(j + 1)) > 0)
                    {
                        Swap (j, j + 1);
                        Console.WriteLine($"{data.ElementAt(j + 1)} > {data.ElementAt(j)} = swap element at position {j} with element at position {j+1}");
                    }
                }
            }

            Console.Write("Sorted Linked List:");

            foreach (var item in data)
            {
                Console.Write(item + " ");
            }
        }
    }
}