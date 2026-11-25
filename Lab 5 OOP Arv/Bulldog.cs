using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_OOP_Arv
{
    internal class Bulldog : Dog
    {
        public bool HasWrinkles { get; set; } = true;

        public Bulldog(string name, int age, double weight, string habitat, string breed, bool hasWrinkles) : base(name, age, weight, habitat, breed)
        {
            HasWrinkles = hasWrinkles;
        }

        public void Snore()
        {
            Console.WriteLine($"{Name} is snoring.");
        }
    }
}
