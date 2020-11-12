using System;
using System.Collections.Generic;
using System.Text;

namespace _101.Animal
{
    public class Fish : Animal
    {
        public Fish(string Name, int Age, char Gender, int Eat) : base(Name, Age, Gender,Eat)
        {
        }

        public override void move()
        {
            Console.WriteLine($"{name} плывет");
        }

        public override string ToString()
        {
            return "Рыба. " + base.ToString() + " Рыба может плавать в воде";
        }
    }
}
