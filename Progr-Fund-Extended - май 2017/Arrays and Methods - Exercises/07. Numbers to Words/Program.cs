using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Numbers_to_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string outputMessage = String.Empty;

            for (int i = 0; i < n; i++)
            {
                var currentNum = int.Parse(Console.ReadLine());
                if (currentNum >= 0 && currentNum < 100)
                {
                    continue;
                }
                else if (currentNum > 999)
                {
                    Console.WriteLine("too large");
                    continue;
                }
                else if (currentNum < -999)
                {
                    Console.WriteLine("too small");
                    continue;
                }

                string message = currentNum < 0 ? "minus " : string.Empty;
                outputMessage = GetNWord(Math.Abs(currentNum));
                Console.WriteLine(message + outputMessage);
            }
        }

        private static string GetNWord(int num)
        {
            string[] toTens = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            string[] teens = { "", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            var message = toTens[num / 100] + "-hundred";
            if (num % 100 == 0)
            {
                return message;
            }
            else if (num % 100 <= 10)
            {
                message = message + " and " + toTens[num % 100];
            }
            else if (num % 100 > 10 && num % 100 <= 19)
            {
                message = message + " and " + teens[num % 10];
            }
            else if (num % 10 == 0)
            {
                message = message + " and " + tens[num % 100 / 10];
            }
            else
            {
                message = message += " and " + tens[num % 100 / 10] + " " + toTens[num % 10];
            }
            return message;
        }
    }
}
