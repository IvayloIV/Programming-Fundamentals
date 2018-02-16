using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Tear_List_in_Half
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().ToList();
            var leftPart = arr.Take(arr.Count() / 2).ToList();
            var rightPart = arr.Skip(arr.Count() / 2).ToList();

            var prossecor = new List<string>();
            for (int i = 0; i < leftPart.Count(); i++)
            {
                var currentArr = new List<string>();
                var item = rightPart[i];
                currentArr.Add(item[0].ToString());
                currentArr.Add(leftPart[i]);
                currentArr.Add(item[1].ToString());
                prossecor.AddRange(currentArr);
            }
            Console.WriteLine(string.Join(" ", prossecor));
        }
    }
}
