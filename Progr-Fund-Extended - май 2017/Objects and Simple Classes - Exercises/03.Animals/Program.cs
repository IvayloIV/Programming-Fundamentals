using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    class Program
    {
        class Dog
        {
            public int Age { get; set; }
            public int NumberOfLeg { get; set; }
            public Dog(int age, int numberOfLeg)
            {
                Age = age;
                NumberOfLeg = numberOfLeg;
            }
            public void ProduceSound()
            {
                Console.WriteLine($"I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
            }
        }
        class Cat
        {
            public int Age { get; set; }
            public int IntelligenceQuotient { get; set; }
            public Cat(int age, int intelligenceQuotient)
            {
                Age = age;
                IntelligenceQuotient = intelligenceQuotient;
            }
            public void ProduceSound()
            {
                Console.WriteLine($"I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
            }
        }
        class Snake
        {
            public int Age { get; set; }
            public int CrueltyCoefficient { get; set; }
            public Snake(int age, int crueltyCoefficient)
            {
                Age = age;
                CrueltyCoefficient = crueltyCoefficient;
            }
            public void ProduceSound()
            {
                Console.WriteLine($"I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
            }
        }
        static void Main(string[] args)
        {
            var dogs = new Dictionary<string, Dog>();
            var cats = new Dictionary<string, Cat>();
            var snakes = new Dictionary<string, Snake>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "I'm your Huckleberry")
                {
                    break;
                }
                var inputTokens = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (inputTokens[0] == "talk")
                {
                    if (dogs.ContainsKey(inputTokens[1]))
                    {
                        dogs[inputTokens[1]].ProduceSound();
                    }
                    else if (cats.ContainsKey(inputTokens[1]))
                    {
                        cats[inputTokens[1]].ProduceSound();
                    }
                    else if (snakes.ContainsKey(inputTokens[1]))
                    {
                        snakes[inputTokens[1]].ProduceSound();
                    }
                }
                else
                {
                    var typePet = inputTokens[0];
                    var name = inputTokens[1];
                    var age = int.Parse(inputTokens[2]);
                    var num = int.Parse(inputTokens[3]);
                    if (typePet == "Dog")
                    {
                        dogs[name] = new Dog(age, num);
                    }
                    else if (typePet == "Cat")
                    {
                        cats[name] = new Cat(age, num);
                    }
                    else if (typePet == "Snake")
                    {
                        snakes[name] = new Snake(age, num);
                    }
                }
            }
            foreach (var item in dogs)
            {
                Console.WriteLine($"Dog: {item.Key}, Age: {item.Value.Age}, Number Of Legs: {item.Value.NumberOfLeg}");
            }
            foreach (var item in cats)
            {
                Console.WriteLine($"Cat: {item.Key}, Age: {item.Value.Age}, IQ: {item.Value.IntelligenceQuotient}");
            }
            foreach (var item in snakes)
            {
                Console.WriteLine($"Snake: {item.Key}, Age: {item.Value.Age}, Cruelty: {item.Value.CrueltyCoefficient}");
            }
        }
    }
}
