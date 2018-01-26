using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SMS_Typing
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var text = "";
            for (int i = 0; i < n; i++)
            {
                var numbers = int.Parse(Console.ReadLine());
                var length = numbers.ToString().Length;
                var mainDigit = int.Parse(new string(numbers.ToString().Take(1).ToArray()));
                var offSet = (mainDigit - 2) * 3;

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offSet++;
                }
                if (offSet < 0) {
                    text += " ";
                    continue;
                }
                var letterIndex = (offSet + length - 1);
                text += (char)(97 + letterIndex);
            }
            Console.WriteLine(text);
        }
    }
}
