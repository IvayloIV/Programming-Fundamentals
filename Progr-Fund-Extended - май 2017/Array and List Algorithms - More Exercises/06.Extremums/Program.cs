using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Extremums
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').ToList();
            var type = Console.ReadLine();
            List<int> outputArr = GetTypeArr(arr, type);
            Console.WriteLine(string.Join(", ", outputArr));
            Console.WriteLine(outputArr.Sum());
        }

        private static List<int> GetTypeArr(List<string> arr, string type)
        {
            var exchangeArr = new List<int>();
            for (int i = 0; i < arr.Count(); i++)
            {
                var currentNumStr = arr[i];
                var currentNum = int.Parse(arr[i]);
                for (int q = 1; q < currentNumStr.Length; q++)
                {
                    var leftPart = new string(currentNumStr.Take(q).ToArray());
                    var rightPart = new string(currentNumStr.Skip(q).ToArray());
                    var momentNum = int.Parse(rightPart + leftPart);
                    if (type == "Max")
                    {
                        if (currentNum < momentNum)
                        {
                            currentNum = momentNum;
                        }
                    }
                    else if (type == "Min")
                    {
                        if (currentNum > momentNum)
                        {
                            currentNum = momentNum;
                        }
                    }
                }
                exchangeArr.Add(currentNum);
            }
            return exchangeArr;
        }
    }
}
