using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Fish_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            MatchCollection findings = Regex.Matches(text, @"([>]*)<([(]+)(['x-]{1})>");
            if (findings.Count == 0)
            {
                Console.WriteLine("No fish found.");
            }
            var count = 1;
            foreach (Match item in findings)
            {
                var tailLength = item.Groups[1].Length;
                var bodyLength = item.Groups[2].Length;
                var status = item.Groups[3].Value;
                Console.WriteLine($"Fish {count}: {item.Value}");
                var typeTail = GetTypeTail(tailLength);
                if (typeTail == "None")
                {
                    Console.WriteLine($"Tail type: {typeTail}");
                }
                else
                {
                    Console.WriteLine($"Tail type: {typeTail} ({tailLength * 2} cm)");
                }
                var typeBody = GetTypeBody(bodyLength);
                Console.WriteLine($"Body type: {typeBody} ({bodyLength * 2} cm)");
                var typeStatus = GetTypeStatus(status);
                Console.WriteLine($"Status: {typeStatus}");
                count++;
            }
        }

        private static string GetTypeStatus(string status)
        {
            if (status == "'")
            {
                return "Awake";
            }
            else if (status == "-")
            {
                return "Asleep";
            }
            else
            {
                return "Dead";
            }
        }

        private static string GetTypeBody(int bodyLength)
        {
            if (bodyLength > 10)
            {
                return "Long";
            }
            else if (bodyLength > 5)
            {
                return "Medium";
            }
            else
            {
                return "Short";
            }
        }

        private static string GetTypeTail(int tailLength)
        {
            if (tailLength > 5)
            {
                return "Long";
            }
            else if (tailLength > 1)
            {
                return "Medium";
            }
            else if (tailLength == 1)
            {
                return "Short";
            }
            else
            {
                return "None";
            }
        }
    }
}
