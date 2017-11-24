using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_5.Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            MatchCollection finding = Regex.Matches(input, @"\b[A-Z][a-z]{1,} [A-Z][a-z]{1,}\b");

            foreach (var item in finding)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}

