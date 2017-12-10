using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var points = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            var chekpoints = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            foreach (var item in names)
            {
                var currentName = item;
                var fullFuel = new string(currentName.Take(1).ToArray());
                double allFuel = char.Parse(fullFuel);

                var isAllOk = true;
                for (int i = 0; i < points.Length; i++)
                {
                    if (chekpoints.Contains(i))
                    {
                        allFuel += points[i];
                    }
                    else
                    {
                        allFuel -= points[i];
                    }
                    if (allFuel <= 0)
                    {
                        isAllOk = false;
                        Console.WriteLine($"{item} - reached {i}");
                        break;
                    }
                }
                if (isAllOk)
                {
                    Console.WriteLine($"{item} - fuel left {allFuel:f2}");
                }
            }
        }
    }
}
