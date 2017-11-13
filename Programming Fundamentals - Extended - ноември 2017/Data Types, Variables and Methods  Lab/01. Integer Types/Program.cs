using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Integer_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            byte small = byte.Parse(Console.ReadLine());
            long big1 = long.Parse(Console.ReadLine());
            long big2 = long.Parse(Console.ReadLine());
            BigInteger big3 = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine($"{small} {big1} {big2} {big3}");
        }
    }
}
