using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_OOP_Arv
{
    internal class Animal
    {
        public string Name { get; set; } = "Unknown";
        public int Age { get; set; } = 0;
        public double Weight { get; set; } = 0.0;
        public string Habitat { get; set; } = "Unknown";
        public bool IsHungry { get; set; } = true;

        public Animal(string name, int age, double weight, string habitat)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Habitat = habitat;
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} makes a sound.");
        }
    }
}
