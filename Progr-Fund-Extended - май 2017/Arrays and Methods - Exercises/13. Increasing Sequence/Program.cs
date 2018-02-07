using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Increasing_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            var prevNum = sequence[0];

            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i] <= prevNum)
                {
                    Console.WriteLine("No");
                    return;
                }
                prevNum = sequence[i];
            }
            Console.WriteLine("Yes");
        }
    }
}
