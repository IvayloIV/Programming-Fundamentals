using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Parking_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var book = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                var inputTokens = Console.ReadLine().Split(' ').ToArray();
                if (inputTokens[0] == "register")
                {
                    var name = inputTokens[1];
                    var licenseNum = inputTokens[2];
                    Match findigNum = Regex.Match(licenseNum, @"^[A-Z]{2}[0-9]{4}[A-Z]{2}$");
                    if (book.Any(a => a.Key == name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {book[name]}");
                        continue;
                    }
                    if (!findigNum.Success)
                    {
                        Console.WriteLine($"ERROR: invalid license plate {licenseNum}");
                        continue;
                    }                   
                    if (book.Any(a => a.Value == licenseNum))
                    {
                        Console.WriteLine($"ERROR: license plate {licenseNum} is busy");
                        continue;
                    }
                    book[name] = licenseNum;
                    Console.WriteLine($"{name} registered {licenseNum} successfully");
                }
                else
                {
                    var name = inputTokens[1];
                    if (book.All(a => a.Key != name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                        continue;
                    }
                    book.Remove(name);
                    Console.WriteLine($"user {name} unregistered successfully");
                }
            }
            foreach (var item in book)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
