using System;
using System.Collections.Generic;
using System.Text;

namespace _101.Animal
{
    public class Bird : Animal
    {
        public Bird(string Name, int Age, char Gender, int Eat) : base(Name, Age, Gender,Eat)
        {
        }

       public void fly()
        {
            Console.WriteLine($"{name} летит");
        }

        public override string ToString()
        {
            return "Птица." + base.ToString() + " Птица умеет ходить и летать";
        }
    }
}
