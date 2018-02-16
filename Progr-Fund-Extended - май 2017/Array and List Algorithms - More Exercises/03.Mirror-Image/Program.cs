using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mirror_Image
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').ToArray();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Print")
                {
                    break;
                }
                var inputNum = int.Parse(input);
                var helperArr = new string[arr.Length];
                for (int i = inputNum - 1; i >= 0; i--)
                {
                    helperArr[inputNum - 1 - i] = arr[i];
                }
                helperArr[inputNum] = arr[inputNum];
                var count = 0;
                for (int i = arr.Length - 1; i >= inputNum + 1; i--)
                {
                    helperArr[inputNum + 1 + count] = arr[i];
                    count++;
                }
                arr = helperArr;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
