using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Tricky_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var delimeter = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());

            var book = new List<string>();
            for (int i = 0; i < n; i++)
            {
                book.Add(Console.ReadLine());
            }
            Console.WriteLine(string.Join(delimeter, book));
        }
    }
}
