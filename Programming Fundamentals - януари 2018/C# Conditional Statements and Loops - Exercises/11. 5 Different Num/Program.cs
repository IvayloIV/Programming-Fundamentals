using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._5_Different_Num
{
    class Program
    {
        static void Main(string[] args)
        {
            var minNum = int.Parse(Console.ReadLine());
            var maxNum = int.Parse(Console.ReadLine());
            var count = true;
            for (int q = minNum; q <= maxNum; q++)
            {
                for (int w = q + 1; w <= maxNum; w++)
                {
                    for (int e = w + 1; e <= maxNum; e++)
                    {
                        for (int r = e + 1; r <= maxNum; r++)
                        {
                            for (int t = r + 1; t <= maxNum; t++)
                            {
                                Console.WriteLine($"{q} {w} {e} {r} {t}");
                                count = false;
                            }
                        }
                    }
                }
            }
            if (count)
            {
                Console.WriteLine($"No");
            }
        }
    }
}
