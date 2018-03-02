using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText("input.txt");
            var output = new List<string>();
            for (int i = 0; i < text.Length; i++)
            {
                output.Add($"{text[i]} -> {(int)(text[i] - 97)}");
            }
            File.WriteAllLines("output.txt", output);
        }
    }
}
