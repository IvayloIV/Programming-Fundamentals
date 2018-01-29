using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (char q = 'a'; q <= (char)n + 96; q++)
            {
                for (char w = 'a'; w <= (char)n + 96; w++)
                {
                    for (char e = 'a'; e <= (char)n + 96; e++)
                    {
                        Console.WriteLine($"{q}{w}{e}");
                    }
                }
            }
        }
    }
}
