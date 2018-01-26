using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.X
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var current = 0;
            var count = n - 2;
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string(' ', i));
                Console.Write('x');
                Console.Write(new string(' ', count));
                Console.Write('x');
                Console.WriteLine(new string(' ', i));
                count -= 2;
                current = i;
            }
            current++;
            Console.Write(new string(' ', current));
            Console.Write('x');
            Console.WriteLine(new string(' ', current));
            current--;
            for (int i = 1; i <= n / 2 * 2; i += 2)
            {
                Console.Write(new string(' ', current));
                Console.Write('x');
                Console.Write(new string(' ', i));
                Console.Write('x');
                Console.WriteLine(new string(' ', current));
                current--;
            }
        }
    }
}
