using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var n1 = Console.ReadLine();
            var n2 = Console.ReadLine();
            var result = GetMax(type, n1, n2);
            Console.WriteLine(result);
        }

        private static object GetMax(string type, string n1, string n2)
        {
            if (type == "int")
            {
                return CalculateInts(n1, n2);
            }
            else if (type == "char")
            {
                var currentResult = CalculateChars(n1, n2);
                var p = 's';
                p = (char)int.Parse(currentResult.ToString());
                return p;
            }
            else
            {
                return CalculateStrings(n1, n2);
            }
        }

        private static object CalculateStrings(string n1, string n2)
        {
            if (n1.CompareTo(n2) >= 0)
            {
                return n1;
            }
            else
            {
                return n2;
            }
        }

        private static object CalculateChars(string n1, string n2)
        {
            var cr1 = (int)char.Parse(n1);
            var cr2 = (int)char.Parse(n2);
            if (cr1 > cr2)
            {
                return cr1;
            }
            else
            {
                return cr2;
            }
        }

        private static object CalculateInts(string n1, string n2)
        {
            var num1 = double.Parse(n1);
            var num2 = double.Parse(n2);
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
    }
}
