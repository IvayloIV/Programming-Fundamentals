using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Triples_of_Latin
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var n = (char)96 + num;

            for (char q = 'a'; q <= n; q++)
            {
                for (char w = 'a'; w <= n; w++)
                {
                    for (char e = 'a'; e <= n; e++)
                    {
                        Console.WriteLine($"{q}{w}{e}");
                    }
                }
            }
        }
    }
}
