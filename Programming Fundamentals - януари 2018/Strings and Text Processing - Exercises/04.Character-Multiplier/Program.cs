using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            var text1 = input[0];
            var text2 = input[1];
            var allSum = 0;
            for (int i = 0; i < Math.Max(text1.Length, text2.Length); i++)
            {
                var firstSum = 1;
                var secondSum = 1;
                if (text1.Length - 1 >= i)
                {
                    firstSum = text1[i];
                }
                if (text2.Length - 1 >= i)
                {
                    secondSum = text2[i];
                }
                allSum += (firstSum * secondSum);
            }
            Console.WriteLine(allSum);
        }
    }
}
