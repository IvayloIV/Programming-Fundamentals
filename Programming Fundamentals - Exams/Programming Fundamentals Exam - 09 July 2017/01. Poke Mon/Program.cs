using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var m = long.Parse(Console.ReadLine());
            var y = long.Parse(Console.ReadLine());

            var half = n * 0.5;
            var count = 0;
            while (n >= m)
            {
                n -= m;
                if (n == half && y != 0)
                {
                    n /= y;
                }
                count++;
            }
            Console.WriteLine(n);
            Console.WriteLine(count);
        }
    }
}
