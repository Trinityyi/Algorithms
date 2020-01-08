using System;
using System.Collections.Generic;
using System.Linq;


namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 1) 
            {
                string[] tokens = args.Skip(1).ToArray();
                Sort.Initialize(new List<int>(tokens.Select(int.Parse).ToArray()));
                Sort.PrintData();

                switch (args[0].ToLower())
                {
                    case "bubble":
                    case "bubblesort":
                    case "1":
                        Sort.BubbleSort();
                        return;
                    case "insertion":
                    case "insertionsort":
                    case "2":
                        Sort.InsertionSort();
                        return;
                    case "selection":
                    case "selectionsort":
                    case "3":
                        Sort.SelectionSort();
                        return;
                    case "merge":
                    case "mergesort":
                    case "4":
                        Sort.MergeSort();
                        return;
                    default:
                        return;
                }
            }
            else {
                Console.WriteLine("Please specify an algorithm and an array of space-separated numbers.");
            }
        }
    }
}
