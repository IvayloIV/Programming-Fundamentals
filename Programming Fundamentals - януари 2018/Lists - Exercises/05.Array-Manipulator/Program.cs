using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToList();
            var command = Console.ReadLine().Split().ToList();

            while (command[0] != "print")
            {
                if (command[0] == "add")
                {
                    var index = int.Parse(command[1]);
                    var element = int.Parse(command[2]);
                    arr.Insert(index, element);
                }
                else if (command[0] == "addMany")
                {
                    var index = int.Parse(command[1]);
                    var newArr = command.Skip(2).Select(int.Parse).ToList();
                    arr.InsertRange(index, newArr);
                }
                else if (command[0] == "contains")
                {
                    var element = int.Parse(command[1]);
                    Console.WriteLine(arr.IndexOf(element));
                }
                else if (command[0] == "remove")
                {
                    var index = int.Parse(command[1]);
                    arr.RemoveAt(index);
                }
                else if (command[0] == "shift")
                {
                    var rotates = int.Parse(command[1]) % arr.Count();
                    var helper = arr.Skip(rotates).ToList();
                    for (int i = 0; i < rotates; i++)
                    {
                        helper.Add(arr[i]);
                    }
                    arr = helper;
                }
                else if (command[0] == "sumPairs")
                {
                    var sumsNums = arr.Count() / 2;
                    for (int i = 0; i < sumsNums; i++)
                    {
                        arr[i] += arr[i + 1];
                        arr.RemoveAt(i + 1);
                    }
                }
                command = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }
    }
}
