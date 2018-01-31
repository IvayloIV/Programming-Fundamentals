using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.String_Concat
{
    class Program
    {
        static void Main(string[] args)
        {
            var delimetre = Console.ReadLine();
            var oddEven = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());

            var text = "";
            for (int i = 1; i <= n; i++)
            {
                var input = Console.ReadLine();
                if (oddEven == "odd" && i % 2 == 1)
                {
                    text += input + delimetre;
                }
                else if (oddEven == "even" && i % 2 == 0)
                {
                    text += input + delimetre;
                }
            }
            text = text.Remove(text.Length - 1);
            Console.WriteLine(text);
        }
    }
}
