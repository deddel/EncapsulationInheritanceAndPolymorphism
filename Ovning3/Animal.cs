using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }

        protected Animal(string name, int weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        public abstract void DoSound(); 

    }

    internal class Horse : Animal
    {
        public Horse(string name, int weight, int age) : base(name, weight, age)
        {
        }

        public override void DoSound()
        {
            Console.WriteLine("Weee ho ho ho");
            //return "Weee ho ho ho";
        }
    }
    internal class Dog : Animal
    {
        public Dog(string name, int weight, int age) : base(name, weight, age)
        {
        }

        public override void DoSound()
        {
            Console.WriteLine("Woff Woff");
            //return "Woff Woff";
        }
    }
    internal class Hedgehog : Animal
    {
        public Hedgehog(string name, int weight, int age) : base(name, weight, age)
        {
        }

        public override void DoSound()
        {
            Console.WriteLine("Hrhg hrgh");
            //return "Hrhg hrgh";
        }
    }
    internal class Worm : Animal
    {
        public Worm(string name, int weight, int age) : base(name, weight, age)
        {
        }

        public override void DoSound()
        {
            Console.WriteLine("Grrsss");
            //return "Grrsss";
        }
    }
    internal class Bird : Animal
    {
        public Bird(string name, int weight, int age) : base(name, weight, age)
        {
        }

        public override void DoSound()
        {
            Console.WriteLine("Chirp Chitt Chitt");
            //return "Chirp Chitt Chitt";
        }
    }

    internal class Wolf : Animal
    {
        public Wolf(string name, int weight, int age) : base(name, weight, age)
        {
        }

        public override void DoSound()
        {
            Console.WriteLine("Aooooooouuuu");
            //return "Aooooooouuuu";
        }
    }
}
