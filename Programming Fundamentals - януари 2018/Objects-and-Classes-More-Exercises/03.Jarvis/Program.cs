using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _03.Jarvis
{
    class Program
    {
        class Arm
        {
            public int EnergyConsume { get; set; }
            public int ArmDistance { get; set; }
            public int Fingers { get; set; }
        }
        class Leg
        {
            public int EnergyConsume { get; set; }
            public int Strenght { get; set; }
            public int Speed { get; set; }
        }
        class Torso
        {
            public int EnergyConsume { get; set; }
            public double SizePros { get; set; }
            public string HousingMaterial { get; set; }
        }
        class Head
        {
            public int EnergyConsume { get; set; }
            public int Iq { get; set; }
            public string SkinMaterial { get; set; }
        }
        static void Main(string[] args)
        {
            var maxPower = BigInteger.Parse(Console.ReadLine());
            var arms = new List<Arm>();
            var legs = new List<Leg>();
            var torso = new Torso();
            var head = new Head();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Assemble!")
                {
                    break;
                }
                var inputTokens = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (inputTokens[0] == "Arm")
                {
                    if (arms.Count() < 2)
                    {
                        var newArm = new Arm();
                        newArm.EnergyConsume = int.Parse(inputTokens[1]);
                        newArm.ArmDistance = int.Parse(inputTokens[2]);
                        newArm.Fingers = int.Parse(inputTokens[3]);
                        arms.Add(newArm);
                    }
                    else
                    {
                        arms = arms.OrderByDescending(a => a.EnergyConsume).ToList();
                        if (arms[0].EnergyConsume > int.Parse(inputTokens[1]))
                        {
                            arms.RemoveAt(0);
                            var newArm = new Arm();
                            newArm.EnergyConsume = int.Parse(inputTokens[1]);
                            newArm.ArmDistance = int.Parse(inputTokens[2]);
                            newArm.Fingers = int.Parse(inputTokens[3]);
                            arms.Add(newArm);
                        }
                    }
                }
                else if (inputTokens[0] == "Leg")
                {
                    if (legs.Count() < 2)
                    {
                        var newLeg = new Leg();
                        newLeg.EnergyConsume = int.Parse(inputTokens[1]);
                        newLeg.Strenght = int.Parse(inputTokens[2]);
                        newLeg.Speed = int.Parse(inputTokens[3]);
                        legs.Add(newLeg);
                    }
                    else
                    {
                        legs = legs.OrderByDescending(a => a.EnergyConsume).ToList();
                        if (legs[0].EnergyConsume > int.Parse(inputTokens[1]))
                        {
                            legs.RemoveAt(0);
                            var newLeg = new Leg();
                            newLeg.EnergyConsume = int.Parse(inputTokens[1]);
                            newLeg.Strenght = int.Parse(inputTokens[2]);
                            newLeg.Speed = int.Parse(inputTokens[3]);
                            legs.Add(newLeg);
                        }
                    }
                }
                else if (inputTokens[0] == "Torso")
                {
                    if (torso.EnergyConsume == 0)
                    {
                        torso.EnergyConsume = int.Parse(inputTokens[1]);
                        torso.SizePros = double.Parse(inputTokens[2]);
                        torso.HousingMaterial = inputTokens[3];
                    }
                    else if (torso.EnergyConsume > int.Parse(inputTokens[1]))
                    {
                        torso.EnergyConsume = int.Parse(inputTokens[1]);
                        torso.SizePros = double.Parse(inputTokens[2]);
                        torso.HousingMaterial = inputTokens[3];
                    }
                }
                else if (inputTokens[0] == "Head")
                {
                    if (head.EnergyConsume == 0)
                    {
                        head.EnergyConsume = int.Parse(inputTokens[1]);
                        head.Iq = int.Parse(inputTokens[2]);
                        head.SkinMaterial = inputTokens[3];
                    }
                    else if (head.EnergyConsume > int.Parse(inputTokens[1]))
                    {
                        head.EnergyConsume = int.Parse(inputTokens[1]);
                        head.Iq = int.Parse(inputTokens[2]);
                        head.SkinMaterial = inputTokens[3];
                    }
                }
            }
            if (legs.Count() < 2 || arms.Count() < 2 || head.EnergyConsume == 0 || torso.EnergyConsume == 0)
            {
                Console.WriteLine($"We need more parts!");
                return;
            }
            BigInteger sumOfPart = legs[0].EnergyConsume + legs[1].EnergyConsume + arms[0].EnergyConsume + arms[1].EnergyConsume + head.EnergyConsume + torso.EnergyConsume;
            if (sumOfPart > maxPower)
            {
                Console.WriteLine($"We need more power!");
            }
            else
            {
                Console.WriteLine($"Jarvis:");
                Console.WriteLine($"#Head:");
                Console.WriteLine($"###Energy consumption: {head.EnergyConsume}");
                Console.WriteLine($"###IQ: {head.Iq}");
                Console.WriteLine($"###Skin material: {head.SkinMaterial}");
                Console.WriteLine($"#Torso:");
                Console.WriteLine($"###Energy consumption: {torso.EnergyConsume}");
                Console.WriteLine($"###Processor size: {torso.SizePros:f1}");
                Console.WriteLine($"###Corpus material: {torso.HousingMaterial}");
                foreach (var item in arms.OrderBy(a => a.EnergyConsume))
                {
                    Console.WriteLine($"#Arm:");
                    Console.WriteLine($"###Energy consumption: {item.EnergyConsume}");
                    Console.WriteLine($"###Reach: {item.ArmDistance}");
                    Console.WriteLine($"###Fingers: {item.Fingers}");
                }
                foreach (var item in legs.OrderBy(a => a.EnergyConsume))
                {
                    Console.WriteLine($"#Leg:");
                    Console.WriteLine($"###Energy consumption: {item.EnergyConsume}");
                    Console.WriteLine($"###Strength: {item.Strenght}");
                    Console.WriteLine($"###Speed: {item.Speed}");
                }
            }
        }
    }
}
