using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_OOP_Arv
{
    internal class Bird : Animal
    {
        public bool CanFly { get; set; } = true;

        public Bird(string name, int age, double weight, string habitat, bool canFly) : base(name, age, weight, habitat)
        {
            CanFly = canFly;
        }

        public void Fly()
        {
            if (CanFly)
            {
                Console.WriteLine($"{Name} is flying!");
            }
            else
            {
                Console.WriteLine($"{Name} cannot fly.");
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Tweet!");
        }
    }
}
