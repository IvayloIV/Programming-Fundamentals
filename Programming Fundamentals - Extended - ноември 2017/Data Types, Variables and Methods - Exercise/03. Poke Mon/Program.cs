using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var average = n / 2.0;
            var count = 0;
            while (n >= m)
            {
                if (n == average)
                {
                    if (y != 0)
                    {
                        n = n / y;
                    }
                    if (n >= m)
                    {
                        n = n - m;
                        count++;
                    }
                }
                else
                {
                    n = n - m;
                    count++;
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(count);
        }
    }
}
