using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            var allLines = File.ReadAllLines("Input.txt").Where((element, index) => index % 2 == 1).ToList();
            File.WriteAllLines("Input.txt", allLines);
        }
    }
}
