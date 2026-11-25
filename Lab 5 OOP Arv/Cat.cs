using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_OOP_Arv
{
    internal class Cat : Animal
    {
        public bool IsIndoor { get; set; } = true;

        public Cat(string name, int age, double weight, string habitat, bool isIndoor) : base(name, age, weight, habitat)
        {
            IsIndoor = isIndoor;
        }

        public void Climb()
        {
            Console.WriteLine($"{Name} is climbing.");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Meow!");
        }
    }
}
