using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Notifications
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var result = Console.ReadLine();
                if (result != "success" && result != "error")
                {
                    continue;
                }
                var operation = Console.ReadLine();
                var message = Console.ReadLine();
                if (result == "success")
                {
                    PrintSuccess(operation, message);
                }
                else if (result == "error")
                {
                    PrintError(operation, message);
                }
            }
        }

        private static void PrintError(string operation, string digitStr)
        {
            Console.WriteLine($"Error: Failed to execute {operation}.");
            Console.WriteLine($"==============================");
            Console.WriteLine($"Error Code: {digitStr}.");
            if (int.Parse(digitStr) >= 0)
            {
                Console.WriteLine($"Reason: Invalid Client Data.");
            }
            else
            {
                Console.WriteLine($"Reason: Internal System Failure.");
            }
        }

        private static void PrintSuccess(string operation, string message)
        {
            Console.WriteLine($"Successfully executed {operation}.");
            Console.WriteLine($"==============================");
            Console.WriteLine($"Message: {message}.");
        }
    }
}
