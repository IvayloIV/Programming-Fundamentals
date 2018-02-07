using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            var startNum = int.Parse(Console.ReadLine());
            var endNum = int.Parse(Console.ReadLine());
            List<int> allNums = FindPrimesInRange(startNum, endNum);
            Console.WriteLine(string.Join(", ", allNums));
        }

        private static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            var allNums = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    allNums.Add(i);
                }
            }
            return allNums;
        }

        private static bool IsPrime(int n)
        {
            int count = (int)Math.Sqrt(n);
            if (n <= 1)
            {
                return false;
            }
            else if (n > 2)
            {
                for (int i = 2; i <= count; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
