using System;
using System.Collections.Generic;
using System.Linq;


namespace BubbleSort
{
    class Program
    {
        BubbleSort algorithm ;

        static void Main(string[] args)
        {
            Program obj = new Program();

            Console.WriteLine("Enter numbers");
            
            string input = Console.ReadLine();
            string[] tokens = input.Split(" ");

            obj.algorithm = new BubbleSort (new LinkedList<int>(tokens.Select(int.Parse).ToArray()));
            
            Console.Write("Unsorted Linked List: ");
            foreach (var item in obj.algorithm.Data)
            {
                Console.Write(item + " ");
            }

            Console.Read();

            obj.algorithm.Sort();
            
            Console.Read();
        }
    }
}

