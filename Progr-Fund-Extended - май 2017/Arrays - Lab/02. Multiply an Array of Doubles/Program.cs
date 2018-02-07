using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Multiply_an_Array_of_Doubles
{
    class Program
    {
        static void Main(string[] args)
        {
            var doublesNums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var myltiply = double.Parse(Console.ReadLine());
            for (int i = 0; i < doublesNums.Length; i++)
            {
                doublesNums[i] *= myltiply;
            }
            for (int i = 0; i < doublesNums.Length; i++)
            {
                Console.Write(doublesNums[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
