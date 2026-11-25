using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_OOP_Arv
{
    internal class Chihuahua : Dog
    {
        public bool IsNervous { get; set; } = true;

        public Chihuahua(string name, int age, double weight, string habitat, string breed, bool isNervous) : base(name, age, weight, habitat, breed)
        {
            IsNervous = isNervous;
        }

        public void Shake()
        {
            Console.WriteLine($"{Name} is shaking.");
        }
    }
}
