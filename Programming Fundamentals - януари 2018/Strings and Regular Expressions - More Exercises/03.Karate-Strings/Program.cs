using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Karate_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var index = text.IndexOf('>');
            var strength = 0;
            while (index != -1)
            {
                strength += int.Parse(text[index + 1].ToString());
                while (strength != 0)
                {
                    if (index + 1 > text.Length - 1)
                    {
                        break;
                    }
                    var currentChar = text[index + 1];
                    if (currentChar == '>')
                    {
                        break;
                    }
                    text = text.Remove(index + 1, 1);
                    strength--;
                }
                index = text.IndexOf('>', index + 1);
            }
            Console.WriteLine(text);
        }
    }
}
