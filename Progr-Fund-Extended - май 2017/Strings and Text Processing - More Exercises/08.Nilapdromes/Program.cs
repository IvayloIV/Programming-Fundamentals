using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Nilapdromes
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end") break;
                for (int i = input.Length / 2 - 1; i >= 0; i--)
                {
                    var leftPart = input.Substring(0, i + 1);
                    var rightPart = input.Substring(input.Length - 1 - i);
                    var currentLength = input.Length - i - i - 2;
                    var middle = input.Substring(i + 1, currentLength);
                    if (leftPart == rightPart && middle != "")
                    {
                        Console.WriteLine(middle + leftPart + middle);
                        break;
                    }
                }
            }
        }
    }
}
