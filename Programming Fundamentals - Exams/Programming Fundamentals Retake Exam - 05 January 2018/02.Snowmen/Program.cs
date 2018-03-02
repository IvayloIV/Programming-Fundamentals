using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            while (arr.Count() > 1)
            {
                for (int i = 0; i < arr.Count(); i++)
                {
                    if (arr[i] == -1)
                    {
                        continue;
                    }
                    if (arr.Where(a => a > -1).Count() == 1)
                    {
                        break;
                    }
                    var attacker = i;
                    var target = arr[i] % arr.Count();
                    var diff = Math.Abs(attacker - target);
                    if (target == attacker)
                    {
                        Console.WriteLine($"{target} performed harakiri");
                        arr[target] = -1;
                    }
                    else if (diff % 2 == 0)
                    {
                        arr[target] = -1;
                        Console.WriteLine($"{attacker} x {target} -> {attacker} wins");
                    }
                    else if (diff % 2 == 1)
                    {
                        arr[attacker] = -1;
                        Console.WriteLine($"{attacker} x {target} -> {target} wins");
                    }
                }
                arr = arr.Where(a => a > -1).ToList();
            }
        }
    }
}
