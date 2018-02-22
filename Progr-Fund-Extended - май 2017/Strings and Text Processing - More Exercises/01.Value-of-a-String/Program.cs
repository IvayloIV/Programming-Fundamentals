using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Value_of_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var typeOfText = Console.ReadLine();
            var sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (typeOfText == "LOWERCASE")
                {
                    if (text[i] >= 97 && text[i] <= 122)
                    {
                        sum += text[i];
                    }
                }
                else
                {
                    if (text[i] >= 65 && text[i] <= 90)
                    {
                        sum += text[i];
                    }
                }
            }
            Console.WriteLine("The total sum is: " + sum);
        }
    }
}
