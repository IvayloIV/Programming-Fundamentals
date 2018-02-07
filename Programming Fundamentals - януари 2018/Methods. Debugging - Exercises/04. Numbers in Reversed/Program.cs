using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Numbers_in_Reversed
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();
            ReverseNum(n);
        }

        private static void ReverseNum(string n)
        {
            var reversedNum = "";
            for (int i = n.Length - 1; i >= 0; i--)
            {
                reversedNum += n[i];
            }
            Console.WriteLine(reversedNum);
        }
    }
}
