using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Decode_Radio_Frequencies
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var outputArr = new List<char>();
            for (int i = 0; i < arr.Length; i++)
            {
                var arrTokens = arr[i].Split('.').Select(int.Parse).ToList();
                if (arrTokens[0] != 0)
                {
                    outputArr.Insert(i, (char)arrTokens[0]);
                }
                if (arrTokens[1] != 0)
                {
                    outputArr.Insert(outputArr.Count() - i, (char)arrTokens[1]);
                }
            }
            Console.WriteLine(string.Join("", outputArr));
        }
    }
}
