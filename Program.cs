using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 1) 
            {
                string path =  Path.Combine(Directory.GetCurrentDirectory(), args[0]);
                if (File.Exists(path))
                {
                    string[] lines = File.ReadAllLines(path);
                    foreach (string line in lines)
                    {
                        string[] tokens = line.Split(null);
                        ParseCommand(tokens[0], tokens.Skip(1).ToArray());
                    }
                }
            }
            else if(args.Length > 1) 
            {
                string[] tokens = args.Skip(1).ToArray();
                ParseCommand(args[0], tokens);
            }
            else {
                Console.WriteLine("Please specify an algorithm and an array of space-separated numbers.");
            }
        }
        
        static void ParseCommand(string algorithm, string[] tokens) {
            Sort.Initialize(new List<int>(tokens.Select(int.Parse).ToArray()),  Path.Combine(Directory.GetCurrentDirectory(), "Results"));

            switch (algorithm.ToLower())
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
                default:
                    return;
            }
        }
    }
}
