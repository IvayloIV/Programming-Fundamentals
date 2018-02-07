using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            PrintResult(n);
        }

        private static void PrintResult(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (IsPalidrom(i) && DivisibleBySeven(i) && HoldsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool HoldsEvenDigit(int i)
        {
            while (i > 0)
            {
                var lastNum = i % 10;
                if (lastNum % 2 == 0)
                {
                    return true;
                }
                i /= 10;
            }
            return false;
        }

        private static bool DivisibleBySeven(int i)
        {
            var sum = 0;
            while (i > 0)
            {
                var lastNum = i % 10;
                sum += lastNum;
                i /= 10;
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsPalidrom(int i)
        {
            if (i < 10)
            {
                return true;
            }
            var iStr = i.ToString(); 
            for (int k = 0; k < iStr.Length / 2; k++)
            {
                if (iStr[k] != iStr[iStr.Length - k - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
