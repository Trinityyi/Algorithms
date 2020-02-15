using System;
using System.Collections.Generic;
using System.IO;

namespace Algorithms
{
    public static partial class Sort 
    {
        static List<int> data = new List<int>();

        static List<int> _data = new List<int>();
        static string exportPath;

        static List<string> exportLines;

        static int stepNo = 0;

        public static List<int> Data
        {
            get 
            {
                return data;
            }
        }
        public static void Initialize(List<int> list, string resultDirectory) 
        {
            exportPath = Path.Combine(resultDirectory,  $"{DateTime.Now.ToString("yyyyMMddHHmmssffff")}.csv");
            exportLines = new List<string>(){ "step_no;step_description;operand_indices;current_state" };
            stepNo = 0;
            data = list;
            _data = list;
            PrintData("init");
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

        public static void PrintData (string label = "?", params int[] operandIndices)
        {
            var line = new {
                step_no = stepNo,
                step_description = label,
                operand_indices = Stringify(operandIndices),
                current_state = Stringify(data)
            };
            exportLines.Add(
                $"{line.step_no};{line.step_description};{line.operand_indices};{line.current_state}"
            );
            if (label == "exit")
            {
                File.WriteAllLines(exportPath, exportLines);
            }
        }

        public static string Stringify<T> (IEnumerable<T> elements, string delimiter = ",") 
        {
            return string.Join(delimiter, elements);
        }

        public static void IncrementStepCounter() {
            stepNo++;
        }
    }
}
