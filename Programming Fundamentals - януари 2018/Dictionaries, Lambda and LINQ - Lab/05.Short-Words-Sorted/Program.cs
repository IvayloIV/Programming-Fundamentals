using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", Console.ReadLine().ToLower()
                .Split(new string[] { ".", ",", ";", ";", "(", ")", "[", "]", "\"", "\'", "\\", "/", "!", "?", " " }, 
                StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .Where(a => a.Length < 5)
                .OrderBy(a => a)
                .ToList()));

        }
    }
}
