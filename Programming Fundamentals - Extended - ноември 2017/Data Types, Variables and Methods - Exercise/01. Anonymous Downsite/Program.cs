using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal secKey = decimal.Parse(Console.ReadLine());

            var sumAll = 0M;
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] { " " },StringSplitOptions.RemoveEmptyEntries).ToArray();
                Console.WriteLine(input[0]);
                var siteVisites = decimal.Parse(input[1]);
                var sitePerViw = decimal.Parse(input[2]);
                var totalSum = siteVisites * sitePerViw;
                sumAll += totalSum;
            }

            Console.WriteLine($"Total Loss: {sumAll:f20}");
            BigInteger sumAll2 = (BigInteger)secKey;

            for (int i = 1; i < n; i++)
            {
                sumAll2 *= (BigInteger)secKey;
            }
            Console.WriteLine($"Security Token: {sumAll2}");
        }
    }
}
