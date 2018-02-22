using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new HashSet<string>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                book.Add(Console.ReadLine());
            }
            Console.WriteLine(string.Join("\n", book));
        }
    }
}
