using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public static partial class Sort 
    {
        public static void BubbleSort()
        {
            Console.WriteLine ("BubbleSort");
            int i, j;
            int size = data.Count;

            for (i = 0; i < size; i++)
            {
                for (j = 0; j < size - 1; j++)
                {
                    IncrementStepCounter();
                    PrintData("comp", j, j+1);
                    if (data.ElementAt(j).CompareTo(data.ElementAt(j + 1)) > 0)
                    {
                        IncrementStepCounter();
                        Swap (j, j + 1);
                        PrintData("swap", j, j+1);
                    }
                }
            }
            IncrementStepCounter();
            PrintData ("exit");
        }
    }
}
