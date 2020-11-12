using System;
using System.Collections.Generic;
using System.Text;

namespace _101.Animal
{
    public class Animal
    {
        public string name;
        public int age;
        public char gender;
        public bool live;
        public int eat;

        public Animal(string Name, int Age, char Gender, int Eat)
        {
            name = Name;
            age = Age;
            gender = Gender;
            eat = Eat;
            live = true;
        }

        virtual public void move()
        {
            Console.WriteLine($"{name} идет");
        }

        virtual public void Eat()
        {
            if (eat == 1)
                Console.WriteLine($"{name} питается мясом)");
            else
                Console.WriteLine($"{name} питается водорослями");
        }

        virtual public Animal Die(Animal a)
        {
            if (a.live)
                a.live = false;
            return a;
        }

        virtual public string Name{
            get
            {
                return name;
            }
            set
            {
                name = value ;
            }
        }

        virtual public int Age{
            get
            {
                return age;
            }
            set 
            {
                age = value;
            }
        }

        virtual public char Gehder
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        virtual public bool Live
        {
            get
            {
                return live;
            }
            set
            {
                live = value;
            }
        }

        public override string ToString()
        {
            string s;
            s = "Имя:" + name + ". Возрвст: " + age;
            if (gender == 'm')
                s = s + ". Пол: мужской.";
            else
                s = s + ". Пол: женский.";
            if (eat == 1)
                s = s + " Хищник.";
            else
                s = s + "Травоядное.";
            return s;
        }
    }
}
