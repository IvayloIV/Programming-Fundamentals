using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            var tikets = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var item in tikets)
            {
                var currentItem = item.Trim(' ');

                if (currentItem.Length != 20)
                {
                    Console.WriteLine($"invalid ticket");
                    continue;
                }

                var symvol = "";
                var isOkey = true;

                var leftPart = new string(currentItem.Take(10).ToArray());
                var rightPart = new string(currentItem.Skip(10).ToArray());

                if (leftPart.Contains('@') && rightPart.Contains('@'))
                {
                    symvol = "@";
                    isOkey = CalculateWithResult(symvol, leftPart, rightPart, currentItem);
                    
                }

                if (leftPart.Contains('#') && rightPart.Contains('#') && isOkey == true)
                {
                    symvol = "#";
                    isOkey = CalculateWithResult(symvol, leftPart, rightPart, currentItem);
                }

                if (leftPart.Contains('$') && rightPart.Contains('$') && isOkey == true)
                {
                    symvol = "$";
                    isOkey = CalculateWithResult(symvol, leftPart, rightPart, currentItem);
                }

                if (leftPart.Contains('^') && rightPart.Contains('^') && isOkey == true)
                {
                    symvol = "^";
                    isOkey = CalculateWithResult(symvol, leftPart, rightPart, currentItem);
                }
                if (isOkey)
                {
                    Console.WriteLine($"ticket \"{currentItem}\" - no match");
                }
            }
        }

        private static bool CalculateWithResult(string symvol, string leftPart, string rightPart, string currentItem)
        {
            Match leftPartFind = Regex.Match(leftPart, $@"\{symvol}+");
            Match rightPartFind = Regex.Match(rightPart, $@"\{symvol}+");

            if (leftPartFind.Length == 10 && rightPartFind.Length == 10)
            {
                Console.WriteLine($"ticket \"{currentItem}\" - 10{symvol} Jackpot!");
                return false;

            }
            else if (Math.Min(leftPartFind.Length, rightPartFind.Length) >= 6)
            {
                Console.WriteLine($"ticket \"{currentItem}\" - {Math.Min(leftPartFind.Length, rightPartFind.Length)}{symvol}");
                return false;
            }
            return true;
        }
    }
}
