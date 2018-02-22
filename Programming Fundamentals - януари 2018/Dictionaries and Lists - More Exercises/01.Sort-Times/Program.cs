using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sort_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = Console.ReadLine().Split(' ').Select(a => DateTime.ParseExact(a, "HH:mm", CultureInfo.InvariantCulture)).ToArray();
            var allData = new List<string>();
            foreach (var item in time.OrderBy(a => a))
            {
                allData.Add($"{item:HH:mm}");
            }
            Console.WriteLine(string.Join(", ", allData));
        }
    }
}
