using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Morse_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            var messages = Console.ReadLine().Split('|').ToArray();
            var outputText = "";
            foreach (var message in messages)
            {
                var countOfZeros = 0;
                var countOfOnes = 0;
                for (int i = 0; i < message.Length; i++)
                {
                    var currentNum = int.Parse(message[i].ToString());
                    if (currentNum == 0)
                    {
                        countOfZeros++;
                    }
                    else if (currentNum == 1)
                    {
                        countOfOnes++;
                    }
                }
                var sequensesCount = 0;
                for (int i = 0; i < message.Length - 1; i++)
                {
                    var currentNum = message[i];
                    var currenSequense = 0;
                    var currentIndex = i;
                    for (int q = currentIndex + 1; q < message.Length; q++)
                    {
                        if (currentNum == message[q])
                        {
                            currenSequense++;
                            i++;
                        }
                        else
                        {
                            break;
                        }
                        if (q == currentIndex + 1)
                        {
                            currenSequense++;
                        }
                    }
                    sequensesCount += currenSequense;
                }
                outputText += (char)(countOfZeros * 3 + countOfOnes * 5 + sequensesCount);
            }
            Console.WriteLine(outputText);
        }
    }
}
