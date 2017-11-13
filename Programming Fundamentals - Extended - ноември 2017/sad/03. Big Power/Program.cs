using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3_Big_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());

            var currentNumber = number;
            for (int i = 1; i < currentNumber; i++)
            {
                number *= currentNumber;
            }
            Console.WriteLine(number);
        }
    }
}
