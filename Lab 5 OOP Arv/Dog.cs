using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_OOP_Arv
{
    internal class Dog : Animal
    {
        public string Breed { get; set; } = "Unknown";

        public Dog(string name, int age, double weight, string habitat, string breed) : base(name, age, weight, habitat)
        {
            Breed = breed;
        }

        public void Bark()
        {
            Console.WriteLine($"{Name} is barking: Woof!");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Woof!");
        }
    }
}
