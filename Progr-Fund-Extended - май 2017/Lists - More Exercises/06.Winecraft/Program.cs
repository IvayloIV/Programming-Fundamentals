using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Winecraft
{
    class Program
    {
        static void Main(string[] args)
        {
            var grape = Console.ReadLine().Split().Select(int.Parse).ToList();
            var m = int.Parse(Console.ReadLine());
            var newArr = new int[grape.Count()];

            var currentLenght = grape.Count();
            while (currentLenght >= m)
            {
                for (int i = 0; i < m; i++)
                {
                    for (int index = 0; index < grape.Count(); index++)
                    {
                        for (int inner = 1; inner < grape.Count() - 1; inner++)
                        {
                            if (grape[inner] > grape[inner + 1] && grape[inner] > grape[inner - 1])
                            {
                                newArr[inner] = 1;
                                newArr[inner - 1] = -1;
                                newArr[inner + 1] = -1;
                            }
                        }
                        if (grape[index] > 0 && newArr[index] == 0)
                        {
                            grape[index]++;
                        }
                        else if (newArr[index] == 1)
                        {
                            grape[index]++;
                            if (grape[index - 1] > 0)
                            {
                                grape[index]++;
                                grape[index - 1]--;
                            }
                            if (grape[index + 1] > 0)
                            {
                                grape[index]++;
                                grape[index + 1]--;
                            }
                            index++;
                        }
                    }
                }
                currentLenght = grape.Count();
                for (int i = 0; i < grape.Count(); i++)
                {
                    if (grape[i] <= m)
                    {
                        grape[i] = 0;
                        currentLenght--;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", grape.Where(a => a != 0)));
        }
    }
}
