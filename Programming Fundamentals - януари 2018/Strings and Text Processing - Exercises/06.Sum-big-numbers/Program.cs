using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = Console.ReadLine();
            var num2 = Console.ReadLine();

            var sum = new List<int>();
            var num1Lenght = num1.Length; 
            var num2Lenght = num2.Length;
            var remain = 0;
            for (int i = 0; i < Math.Max(num1Lenght, num2Lenght); i++)
            {
                var currentSum = 0;
                currentSum += remain;
                remain = 0;
                if (num1Lenght - 1 >= i)
                {
                    currentSum += int.Parse(num1[num1Lenght - 1 - i].ToString());
                }
                if (num2Lenght - 1 >= i)
                {
                    currentSum += int.Parse(num2[num2Lenght - 1 - i].ToString());
                }
                if (currentSum >= 10)
                {
                    remain++;
                    currentSum -= 10;
                }
                sum.Add(currentSum);
            }
            var isStart = false;
            if (remain != 0)
            {
                Console.Write(remain);
                isStart = true;
            }
            for (int i = 0; i < sum.Count(); i++)
            {
                if (isStart == false && sum[sum.Count() - 1 - i] == 0)
                {
                    continue;
                }
                Console.Write(sum[sum.Count() - 1 - i]);
                isStart = true;
            }
            Console.WriteLine();
        }
    }
}
