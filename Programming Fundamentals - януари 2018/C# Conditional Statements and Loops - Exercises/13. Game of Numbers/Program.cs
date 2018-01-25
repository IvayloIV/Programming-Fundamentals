using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var startNum = int.Parse(Console.ReadLine());
            var endNum = int.Parse(Console.ReadLine());
            var magicNum = int.Parse(Console.ReadLine());

            var count = 0;
            for (int i = endNum; i >= startNum; i--)
            {
                for (int k = endNum; k >= startNum; k--)
                {
                    count++;
                    if (i + k == magicNum)
                    {
                        Console.WriteLine($"Number found! {i} + {k} = {magicNum}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{count} combinations - neither equals {magicNum}");
        }
    }
}
