using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Andrey_and_Billiard
{
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, double> Order { get; set; }
        public double Bill { get; set; }

        public Customer(string name)
        {
            Name = name;
            Order = new Dictionary<string, double>();
            Bill = 0d;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var products = new Dictionary<string, double>();
            for (int i = 0; i < n; i++)
            {
                var currentProduct = Console.ReadLine().Split('-').ToArray();
                products[currentProduct[0]] = double.Parse(currentProduct[1]);
            }
            var peoples = new List<Customer>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end of clients")
                {
                    break;
                }
                var inputTokens = input.Split(new[] { ",", "-" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var name = inputTokens[0];
                var product = inputTokens[1];
                var quantity = int.Parse(inputTokens[2]);
                if (!products.ContainsKey(product))
                {
                    continue;
                }
                if (peoples.All(a => a.Name != name))
                {
                    var newPeople = new Customer(name);
                    newPeople.Order[product] = quantity; 
                    newPeople.Bill += (quantity * products[product]);
                    peoples.Add(newPeople);
                }
                else
                {
                    foreach (var item in peoples)
                    {
                        if (item.Name == name)
                        {
                            if (!item.Order.ContainsKey(product))
                            {
                                item.Order[product] = 0;
                            }
                            item.Order[product] += quantity;
                            item.Bill += (quantity * products[product]);
                        }
                    }
                }
            }
            foreach (var item in peoples.OrderBy(a => a.Name))
            {
                Console.WriteLine(item.Name);
                foreach (var item2 in item.Order)
                {
                    Console.WriteLine($"-- {item2.Key} - {item2.Value}");
                }
                Console.WriteLine($"Bill: {item.Bill:f2}");
            }
            Console.WriteLine($"Total bill: {(peoples.Sum(a => a.Bill)):f2}");
        }
    }
}
