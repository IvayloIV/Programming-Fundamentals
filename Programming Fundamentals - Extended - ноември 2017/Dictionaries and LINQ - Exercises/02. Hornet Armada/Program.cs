using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2.Hornet_Armada
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var book = new Dictionary<string, long>();
            var book2 = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < n; i++)
            {
                Match finding = Regex.Match(Console.ReadLine(), @"^(.*?) = (.*?) -> (.*?):([0-9]+)$");
                var lastActyvity = long.Parse(finding.Groups[1].Value);
                var legionName = finding.Groups[2].Value;
                var name = finding.Groups[3].Value;
                var countSoldier = long.Parse(finding.Groups[4].Value);

                if (!book.ContainsKey(legionName))
                {
                    book[legionName] = 0;
                }
                if (book[legionName] < lastActyvity)
                {
                    book[legionName] = lastActyvity;
                }

                if (!book2.ContainsKey(legionName))
                {
                    book2[legionName] = new Dictionary<string, long>();
                }

                if (!book2[legionName].ContainsKey(name))
                {
                    book2[legionName][name] = 0;
                }
                book2[legionName][name] += countSoldier;
            }
            var output = Console.ReadLine().Split('\\').ToArray();

            if (output.Length == 2)
            {
                var activ = long.Parse(output[0]);
                var name = output[1];
                var book3 = new Dictionary<string, long>();

                foreach (var item in book.Where(a => a.Value < activ))
                {
                    foreach (var item2 in book2.Where(a => a.Key == item.Key))
                    {
                        foreach (var item3 in item2.Value)
                        {
                            if (item3.Key == name)
                            {
                                book3[item2.Key] = item3.Value;
                            }
                        }
                    }
                }

                foreach (var item in book3.OrderByDescending(a => a.Value))
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }
            else
            {
                var post = output[0];
                var book3 = new Dictionary<string, long>();

                foreach (var item in book2)
                {
                    foreach (var item2 in item.Value)
                    {
                        if (item2.Key == post)
                        {
                            foreach (var item3 in book.Where(a => a.Key == item.Key))
                            {
                                book3[item3.Key] = item3.Value;
                            }
                            break;
                        }
                    }
                }

                foreach (var item in book3.OrderByDescending(a => a.Value))
                {
                    Console.WriteLine($"{item.Value} : {item.Key}");
                }
            }
        }
    }
}
