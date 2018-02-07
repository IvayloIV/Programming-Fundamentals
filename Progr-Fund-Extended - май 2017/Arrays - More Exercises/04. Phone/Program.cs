using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var names = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "done")
                {
                    break;
                }
                var inputTokens = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var name = "";
                var number = "";

                if (numbers.Contains(inputTokens[1]))
                {
                    number = inputTokens[1];
                    name = GetName(numbers, number, names);
                    if (inputTokens[0] == "call")
                    {
                        Console.WriteLine($"calling {name}...");
                    }
                    else
                    {
                        Console.WriteLine($"sending sms to {name}...");
                    }
                }
                else if (names.Contains(inputTokens[1]))
                {
                    name = inputTokens[1];
                    number = GetNumber(names, name, numbers);
                    if (inputTokens[0] == "call")
                    {
                        Console.WriteLine($"calling {number}...");
                    }
                    else
                    {
                        Console.WriteLine($"sending sms to {number}...");
                    }
                }
                var sum = GetSum(number);

                PrintResult(inputTokens, sum);              
            }
        }

        private static void PrintResult(string[] inputTokens, int sum)
        {
            if (inputTokens[0] == "call")
            {
                if (sum % 2 == 0)
                {
                    Console.WriteLine($"call ended. duration: {(sum / 60):d2}:{(sum % 60):d2}");
                }
                else
                {
                    Console.WriteLine($"no answer");
                }
            }
            else if (inputTokens[0] == "message")
            {
                if (sum % 2 == 0)
                {
                    Console.WriteLine($"meet me there");
                }
                else
                {
                    Console.WriteLine($"busy");
                }
            }
        }

        private static int GetSum(string number)
        {
            var sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] >= 48 && number[i] <= 57)
                {
                    sum += int.Parse(number[i].ToString());
                }
            }
            return sum;
        }

        private static string GetNumber(string[] names, string name, string[] numbers)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    return numbers[i];
                }
            }
            return "";
        }

        private static string GetName(string[] numbers, string number, string[] names)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    return names[i];
                }
            }
            return "";
        }
    }
}
