using System;
using System.Collections.Generic;
using System.Linq;


namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();

            Console.WriteLine("Enter numbers");
            
            string input = Console.ReadLine();
            string[] tokens = input.Split(" ");

            Sort.Initialize(new List<int>(tokens.Select(int.Parse).ToArray()));
            
            Console.Write("Unsorted Linked List: ");
            foreach (var item in Sort.Data)
            {
                Console.Write(item + " ");
            }

            Sort.BubbleSort();
        }
    }
}

