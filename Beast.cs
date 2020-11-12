using System;
using System.Collections.Generic;
using System.Text;

namespace _101.Animal
{
    public class Beast : Animal
    {
        public Beast(string Name, int Age, char Gender, int Eat) : base(Name, Age, Gender,Eat)
        {
        }

        public override string ToString()
        {
            return "Зверь. " + base.ToString() + " Зверь может идти по земле(или по Луне:)";
        }
    }
}
