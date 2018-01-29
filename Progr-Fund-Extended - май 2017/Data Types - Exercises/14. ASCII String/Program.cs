using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ASCII_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var text = "";
            for (int i = 0; i < n; i++)
            {
                var character = (char)int.Parse(Console.ReadLine());
                text += character;
            }
            Console.WriteLine(text);
        }
    }
}
