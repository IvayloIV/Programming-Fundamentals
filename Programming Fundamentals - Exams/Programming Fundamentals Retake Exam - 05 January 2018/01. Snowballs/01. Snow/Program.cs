using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Snow
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            BigInteger maxValue = long.MinValue;

            var output = "";
            for (int i = 0; i < n; i++)
            {
                var snowballSnow = decimal.Parse(Console.ReadLine());
                var snowballTime = decimal.Parse(Console.ReadLine());
                var snowballQuality = decimal.Parse(Console.ReadLine());

                var snowballSnowTime = snowballSnow / snowballTime;
                BigInteger result = 1;
                for (int k = 0; k < snowballQuality; k++)
                {
                    result *= (BigInteger)snowballSnowTime;
                }

                if (maxValue < result)
                {
                    maxValue = result;
                    output = $"{snowballSnow} : {snowballTime} = {result} ({snowballQuality})";
                }
            }
            Console.WriteLine(output);
        }
    }
}
