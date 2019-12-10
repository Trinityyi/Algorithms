using System;
using System.Collections.Generic;
using System.Linq;


namespace Algorithms
{
    public class BubbleSort
    {
        LinkedList<int> data = new LinkedList<int>();

        public LinkedList<int> Data{
            get {
                return data;
            }
        }
        
        public BubbleSort (LinkedList<int> linkedList) 
        {
            data = linkedList;
        }
        
        public void Sort()
        {
            int i, j;
            int size = data.Count;

            for (i = 0; i < size; i++)
            {
                for (j = 0; j < size - 1; j++)
                {
                    if (data.ElementAt(j).CompareTo(data.ElementAt(j + 1)) > 0)
                    {
                        LinkedListNode<int> current = data.Find(data.ElementAt(j));
                        Swap (current);
                    }
                }
            }

            Console.Write("Sorted Linked List:");

            i = 1;
            foreach (var item in data)
            {
                Console.Write(item + " ");
            }
        }
        private void Swap (LinkedListNode<int> node) 
        {
            var temp = node.Next.Value;
            node.Next.Value = node.Value;
            node.Value = temp;
        }
    }
}

