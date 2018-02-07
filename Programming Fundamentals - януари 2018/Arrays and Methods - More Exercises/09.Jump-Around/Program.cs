using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Jump_Around
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            long sum = 0;

            var index = 0;
            sum += arr[index];
            while (true)
            {
                var currentNum = arr[index];
                if (index + currentNum <= arr.Length - 1)
                {
                    index = index + currentNum;
                    sum += arr[index];
                }
                else if (index - currentNum > 0)
                {
                    index = index - currentNum;
                    sum += arr[index];
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
