using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstWord = Console.ReadLine();
            var secondWord = Console.ReadLine();
            var firstArr = firstWord.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var secondArr = secondWord.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            if (firstWord.Length < secondWord.Length)
            {
                PrintArr(firstArr);
                PrintArr(secondArr);
            }
            else if (firstWord.Length > secondWord.Length)
            {
                PrintArr(secondArr);
                PrintArr(firstArr);
            }
            else
            {
                for (int i = 0; i < firstArr.Length; i++)
                {
                    if (char.Parse(firstArr[i]) < char.Parse(secondArr[i]))
                    {
                        PrintArr(firstArr);
                        PrintArr(secondArr);
                        return;
                    }
                    else if (char.Parse(firstArr[i]) > char.Parse(secondArr[i]))
                    {
                        PrintArr(secondArr);
                        PrintArr(firstArr);
                        return;
                    }
                }
                PrintArr(firstArr);
                PrintArr(secondArr);
            }
        }

        private static void PrintArr(string[] firstArr)
        {
            for (int i = 0; i < firstArr.Length; i++)
            {
                Console.Write(firstArr[i]);
            }
            Console.WriteLine();
        }
    }
}
