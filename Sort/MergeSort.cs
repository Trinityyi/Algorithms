using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public static partial class Sort 
    {
        public static void MergeSort()
        {
            Console.WriteLine ("MergeSort");

            data = Divide(data);

            PrintData ("Sorted List");
        }

        public static List<int> Divide (List<int> sublist)
        {
            if (sublist.Count <= 1) return sublist;

            int midPoint = sublist.Count/2;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for (int i = 0; i < midPoint;i++)  
            {
                left.Add(sublist[i]);
            }
            for (int i = midPoint; i < sublist.Count; i++)
            {
                right.Add(sublist[i]);
            }

            left = Divide(left);
            right = Divide(right);
            return Merge(left,right);
        }
        
        public static List<int> Merge (List<int> left, List<int> right)
        {
            List<int> sorted = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First()) 
                    {
                        sorted.Add(left.First());
                        left.Remove(left.First());      
                    }
                    else
                    {
                        sorted.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if(left.Count > 0)
                {
                    sorted.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    sorted.Add(right.First());

                    right.Remove(right.First());    
                }    
                
            }
            Console.WriteLine($"{String.Join(" ", sorted.ToArray())}");

            return sorted ;

        }
    }
}
