using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = int.Parse(Console.ReadLine());
            var book = new Dictionary<char, int>();
            book['A'] = 1;
            book['C'] = 2;
            book['G'] = 3;
            book['T'] = 4;

            foreach (var one in book)
            {
                foreach (var two in book)
                {
                    foreach (var three in book)
                    {
                        if (one.Value + two.Value + three.Value >= sum)
                        {
                            Console.Write($"O{one.Key}{two.Key}{three.Key}O ");
                        }
                        else
                        {
                            Console.Write($"X{one.Key}{two.Key}{three.Key}X ");
                        }
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}
