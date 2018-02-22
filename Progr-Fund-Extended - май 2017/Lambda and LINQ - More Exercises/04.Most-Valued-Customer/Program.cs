using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Most_Valued_Customer
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, double>();
            var customers = new Dictionary<string, List<string>>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Shop is open")
                {
                    break;
                }
                var inputTokens = input.Split(' ');
                products[inputTokens[0]] = double.Parse(inputTokens[1]);
            }
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Print")
                {
                    break;
                }
                if (input == "Discount")
                {
                    var newBook = new Dictionary<string, double>();
                    foreach (var item in products.OrderByDescending(a => a.Value).Take(3))
                    {
                        newBook[item.Key] = item.Value * 0.9;
                    }
                    foreach (var item in newBook)
                    {
                        products[item.Key] = item.Value;
                    }
                }
                else
                {
                    var inputTokens = input.Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    var name = inputTokens[0];
                    var productsPerson = inputTokens[1].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    if (!customers.ContainsKey(name))
                    {
                        customers[name] = new List<string>();
                    }
                    foreach (var item in productsPerson)
                    {
                        if (products.ContainsKey(item))
                        {
                            customers[name].Add(item);
                        }
                    }
                }
            }
            var pricePerson = new Dictionary<string, double>();
            foreach (var item in customers)
            {
                if (!pricePerson.ContainsKey(item.Key))
                {
                    pricePerson[item.Key] = 0.0;
                }
                foreach (var item2 in item.Value)
                {
                    pricePerson[item.Key] += products[item2];
                }
            }
            foreach (var item in pricePerson.OrderByDescending(a => a.Value).Take(1))
            {
                Console.WriteLine($"Biggest spender: {item.Key}");
                Console.WriteLine("^Products bought:");
                foreach (var item2 in products.OrderByDescending(a => a.Value))
                {
                    if (customers[item.Key].Contains(item2.Key))
                    {
                        Console.WriteLine($"^^^{item2.Key}: {products[item2.Key]:f2}");
                    }
                }
                Console.WriteLine($"Total: {item.Value:f2}");
            }
        }
    }
}
