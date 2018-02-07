using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var arrInput = new int[n + 1];
            var checksNum = new bool[n + 1];

            string primesNums = null;

            for (int i = 0; i <= n; i++)
            {
                arrInput[i] = i;
                checksNum[i] = true;
            }

            primesNums = SieveOfErat(arrInput, checksNum, primesNums);

            Console.WriteLine(primesNums.Trim());
        }

        private static string SieveOfErat(int[] arrInput, bool[] checksNum, string primesNums)
        {
            checksNum[0] = false;
            checksNum[1] = false;

            for (int i = 0; i < arrInput.Length; i++)
            {
                if (!checksNum[i])
                {
                    continue;
                }
                primesNums += $"{arrInput[i]} ";
                for (int q = i + 1; q < arrInput.Length; q++)
                {
                    if (arrInput[q] % i == 0 && checksNum[q] == true)
                    {
                        checksNum[q] = false;
                    }
                }
            }

            return primesNums;
        }
    }
}
