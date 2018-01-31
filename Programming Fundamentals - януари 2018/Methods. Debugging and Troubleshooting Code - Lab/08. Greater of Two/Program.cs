using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Greater_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var first = Console.ReadLine();
            var second = Console.ReadLine();
            Console.WriteLine(PrintMax(type, first, second)); 
        }

        private static string PrintMax(string type, string first, string second)
        {
            if (type == "int")
            {
                return PrintMaxInt(first, second);
            }
            else if (type == "char")
            {
                return PrintCharMax(first, second);
            }
            else
            {
                return PrintStringMax(first, second);
            }
        }

        private static string PrintStringMax(string first, string second)
        {
            if (first.CompareTo(second) > 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        private static string PrintCharMax(string first, string second)
        {
            var firstChar = char.Parse(first);
            var secondChar = char.Parse(second);
            if (firstChar >= secondChar)
            {
                return firstChar.ToString();
            }
            else
            {
                return secondChar.ToString();
            }
        }

        private static string PrintMaxInt(string first, string second)
        {
            var firstNum = int.Parse(first);
            var secondNum = int.Parse(second);
            if (firstNum < secondNum)
            {
                return second;
            }
            else
            {
                return first;
            }
        }
    }
}
