using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Max_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var allLines = File.ReadAllLines("input.txt");
            var output = new List<string>();
            foreach (var line in allLines)
            {
                var arr = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                var maxSequenceCount = 0;
                var maxNum = 0;
                var momentSequenceCount = 1;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] == arr[i + 1])
                    {
                        momentSequenceCount++;
                    }
                    else
                    {
                        momentSequenceCount = 1;
                    }
                    if (maxSequenceCount < momentSequenceCount)
                    {
                        maxSequenceCount = momentSequenceCount;
                        maxNum = arr[i];
                    }
                }
                var finalText = "";
                for (int i = 0; i < maxSequenceCount; i++)
                {
                    finalText += maxNum + " ";
                }
                output.Add(finalText.Trim());
            }
            File.WriteAllLines("output.txt", output);
        }
    }
}
