using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02.Convert_from_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            BigInteger system = BigInteger.Parse(input[0]);
            var numStr = input[1];
            var count = 0;
            BigInteger sum = 0;
            for (int i = numStr.Length - 1; i >= 0; i--)
            {
                sum += BigInteger.Parse(numStr[i].ToString()) * GetPowNum(system, count);
                count++;
            }
            Console.WriteLine(sum);
        }

        private static BigInteger GetPowNum(BigInteger system, int count)
        {
            BigInteger sum = 1;
            for (int i = 0; i < count; i++)
            {
                sum *= system;
            }
            return sum;
        }
    }
}
