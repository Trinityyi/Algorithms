using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public static partial class Sort 
    {
        public static void SelectionSort()
        {
            Console.WriteLine ("SelectionSort");
            int i, j, minPos;
            int size = data.Count;

            for (i = 0; i < size-1; i++)
            {
                minPos = i;
                for (j = i+1 ; j < size; j++)
                {
                    IncrementStepCounter();
                    PrintData("comp", minPos, j);
                    if (data.ElementAt(minPos).CompareTo(data.ElementAt(j)) > 0)
                    {
                        minPos = j;
                    }                    
                }
                IncrementStepCounter();
                Swap(minPos,i);
                PrintData("swap", minPos, i);
            }
            IncrementStepCounter();
            PrintData ("exit");
        }
    }
}
