using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Find_the_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var tokens = Console.ReadLine().Split(' ').ToArray();
            var index = 0;
            for (int i = 0; i < int.Parse(tokens[1]); i++)
            {
                index = text.IndexOf(tokens[0], index == 0 ? 0 : index + 1);
                if (index < 0) break;
            }
            if (index == -1) Console.WriteLine($"Find the letter yourself!");
            else Console.WriteLine(index);
        }
    }
}
