using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Convert_from_base_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            var system = int.Parse(input[0]);
            BigInteger num = BigInteger.Parse(input[1].ToString());
            var builder = new StringBuilder();
            while (num > 0)
            {
                builder.Append(num % system);
                num /= system;
            }
            Console.WriteLine(string.Join("", builder.ToString().Reverse()));
        }
    }
}
