using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var outputArr = new List<int>();
            for (int i = 0; i < arr.Count(); i++)
            {
                var sqrtNum = Math.Sqrt(arr[i]);
                if (Math.Round(sqrtNum) == sqrtNum)
                {
                    outputArr.Add(arr[i]);
                }
            }
            outputArr.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" " , outputArr));
        }
    }
}
