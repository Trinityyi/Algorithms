using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public static partial class Sort 
    {
        static List<int> data = new List<int>();

        static List<int> _data = new List<int>();

        public static List<int> Data
        {
            get 
            {
                return data;
            }
        }
        public static void Initialize(List<int> list) 
        {
            data = list;
            _data = list;
        }

        public static void Reset() 
        {
            data = _data;
        }

        private static void Swap (int posI, int posJ) 
        {
            var temp = data[posI];
            data[posI] = data[posJ];
            data[posJ] = temp;
        }
    }
}
