using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Multiply_big_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = Console.ReadLine();
            var num2 = int.Parse(Console.ReadLine());

            var sum = new List<int>();
            var num1Lenght = num1.Length;
            var remain = 0;
            var currentSum = 0;
            for (int i = 0; i < num1Lenght; i++)
            {
                currentSum += int.Parse(num1[num1Lenght - 1 - i].ToString()) * num2;
                if (currentSum >= 10)
                {
                    remain += int.Parse(new string(currentSum.ToString().Take(1).ToArray()));
                    currentSum -= (remain * 10);
                }
                sum.Add(currentSum);
                currentSum = remain;
                remain = 0;
            }
            var isStart = false;
            if (currentSum != 0)
            {
                Console.Write(currentSum);
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
            if (isStart == false)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
