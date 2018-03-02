using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var allLines = File.ReadAllLines("input.txt");
            var output = new List<string>();
            for (int i = 0; i < allLines.Length - 1; i += 2)
            {
                var name = allLines[i];
                var email = allLines[i + 1];
                if (email.EndsWith("us") || email.EndsWith("uk"))
                {
                    continue;
                }
                output.Add($"{name} -> {email}");
            }
            File.WriteAllLines("output.txt", output);
        }
    }
}
