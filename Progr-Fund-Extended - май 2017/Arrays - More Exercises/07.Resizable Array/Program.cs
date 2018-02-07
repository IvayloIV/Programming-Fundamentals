using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Resizable_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[4];

            var index = 0;
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                var inputTokens = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (inputTokens[0] == "push")
                {
                    if (index > arr.Length - 1)
                    {
                        var newArr = new string[arr.Length + 1];
                        for (int i = 0; i < newArr.Length; i++)
                        {
                            if (i > arr.Length - 1)
                            {
                                newArr[i] = inputTokens[1];
                            }
                            else
                            {
                                newArr[i] = arr[i];
                            }
                        }
                        arr = newArr;
                    }
                    else
                    {
                        arr[index] = inputTokens[1];
                    }
                }
                else if (inputTokens[0] == "pop")
                {
                    for (int i = arr.Length - 1; i >= 0; i--)
                    {
                        if (arr[i] != null)
                        {
                            arr[i] = null;
                            index = i - 1;
                            break;
                        }
                    }
                }
                else if (inputTokens[0] == "removeAt")
                {
                    var newArr = new string[arr.Length - 1];
                    var currentIndex = 0;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (i == int.Parse(inputTokens[1]))
                        {
                            continue;
                        }
                        else
                        {
                            newArr[currentIndex] = arr[i];
                            currentIndex++;
                        }
                    }
                    arr = newArr;
                    index -= 2;
                }
                else if (inputTokens[0] == "clear")
                {
                    arr = new string[4];
                    index = -1;
                }

                if (index < 0)
                {
                    index = 0;
                }
                else
                {
                    index++;
                }
            }
            if (arr.All(a => a == null))
            {
                Console.WriteLine("empty array");
                return;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
