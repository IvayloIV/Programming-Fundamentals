using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "3:1")
                {
                    break;
                }

                var all = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (all[0] == "merge")
                {
                    var startIndex = int.Parse(all[1]);
                    var endIndex = int.Parse(all[2]);

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    else if (startIndex > arr.Count - 1)
                    {
                        startIndex = arr.Count - 1;
                    }


                    if (endIndex < 0)
                    {
                        endIndex = 0;
                    }
                    else if (endIndex > arr.Count - 1)
                    {
                        endIndex = arr.Count - 1;
                    }

                    if (startIndex >= endIndex)
                    {
                        continue;
                    }

                    var newSt = "";
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        newSt += arr[i];
                    }
                    var leftPart = arr.Take(startIndex).ToList();
                    var right = arr.Skip(endIndex + 1).ToList();

                    arr = leftPart;
                    arr.Add(newSt);
                    arr.AddRange(right);
                }
                else if (all[0] == "divide")
                {
                    var index = int.Parse(all[1]);
                    var partition = int.Parse(all[2]);

                    if (arr[index].Length % partition == 0)
                    {
                        var divaider = arr[index].Length / partition;
                        var currentWord = arr[index];

                        var currentArray = new List<string>();
                        currentArray.AddRange(arr.Take(index).ToArray());
                        currentArray.Add(new string(currentWord.Take(divaider).ToArray()));

                        var skips = divaider;

                        for (int i = divaider; i < currentWord.Length; i += divaider)
                        {
                            currentArray.Add(new string(currentWord.Skip(skips).Take(divaider).ToArray()));
                            skips += divaider;
                        }
                        currentArray.AddRange(arr.Skip(index + 1).ToArray());
                        arr = currentArray;
                    }
                    else
                    {
                        var divaider = (int)Math.Floor((double)arr[index].Length / partition);
                        var currentWord = arr[index];

                        var currentArray = new List<string>();
                        currentArray.AddRange(arr.Take(index).ToArray());
                        currentArray.Add(new string(currentWord.Take(divaider).ToArray()));

                        var skips = divaider;

                        for (int i = 0; i < partition - 2; i++)
                        {
                            currentArray.Add(new string(currentWord.Skip(skips).Take(divaider).ToArray()));
                            skips += divaider;
                        }
                        currentArray.Add(new string(currentWord.Skip(skips).ToArray()));
                        currentArray.AddRange(arr.Skip(index + 1).ToArray());
                        arr = currentArray;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
