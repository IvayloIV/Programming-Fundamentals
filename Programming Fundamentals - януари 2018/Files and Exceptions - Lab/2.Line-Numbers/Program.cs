using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var allLines = File.ReadAllLines("Input.txt").ToList();
            for (int i = 0; i <= allLines.Count() - 1; i++)
            {
                allLines[i] = $"{i + 1}. " + allLines[i];
            }
            File.WriteAllLines("Input.txt", allLines);
        }
    }
}
