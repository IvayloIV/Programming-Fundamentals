using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var count = 0;
            var balance = "BALANCED";
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                if (input == "(")
                {
                    if (count % 2 == 0)
                    {
                        count++;
                    }
                    else
                    {
                        balance = "UNBALANCED";
                        break;
                    }
                }
                else if (input == ")")
                {
                    if (count % 2 == 1)
                    {
                        count++;
                    }
                    else
                    {
                        balance = "UNBALANCED";
                        break;
                    }
                }
            }
            if (count % 2 == 1)
            {
                balance = "UNBALANCED";
            }
            Console.WriteLine(balance);
        }
    }
}
