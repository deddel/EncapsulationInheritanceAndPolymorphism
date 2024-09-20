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
        public int TopSpeed { get; set; }
        public Horse(string name, int weight, int age, int topSpeed) : base(name, weight, age)
        
        {
            TopSpeed = topSpeed;
        }

        public override void DoSound()
        {
            Console.WriteLine("Weee ho ho ho");
            //return "Weee ho ho ho";
        }
    }
    internal class Dog : Animal
    {
        public string Breed { get; set; }
        public Dog(string name, int weight, int age, string breed) : base(name, weight, age)
        {
            Breed = breed;
        }


        public override void DoSound()
        {
            Console.WriteLine("Woff Woff");
            //return "Woff Woff";
        }
    }
    internal class Hedgehog : Animal
    {
        public int NumberOfSpikes { get; set; }
        public Hedgehog(string name, int weight, int age, int numberOfSpikes) : base(name, weight, age)
        {
            NumberOfSpikes = numberOfSpikes;
        }

        public override void DoSound()
        {
            Console.WriteLine("Hrhg hrgh");
            //return "Hrhg hrgh";
        }
    }
    internal class Worm : Animal
    {
        public bool IsPoisonous { get; set; }
        public Worm(string name, int weight, int age, bool isPoisonous) : base(name, weight, age)
        {
            IsPoisonous = isPoisonous;
        }

        public override void DoSound()
        {
            Console.WriteLine("Grrsss");
            //return "Grrsss";
        }
    }
    internal class Bird : Animal
    {
        public int WingSpan { get; set; }
        public Bird(string name, int weight, int age, int wingSpan) : base(name, weight, age)
        {
            WingSpan = wingSpan;
        }


        public override void DoSound()
        {
            Console.WriteLine("Chirp Chitt Chitt");
            //return "Chirp Chitt Chitt";
        }
    }

    internal class Pelican : Bird
    {
        
        public string SubSpieces { get; set; }
        public Pelican(string name, int weight, int age, int wingSpan, string subSpieces) : base(name, weight, age, wingSpan)
        {
            SubSpieces = subSpieces;
        }
    }
    internal class Flamingo : Bird
    {
        public string Continent { get; set; }
        public Flamingo(string name, int weight, int age, int wingSpan, string continent) : base(name, weight, age, wingSpan)
        {
            Continent = continent;
        }

    }
    internal class Swan : Bird
    {
        public bool Migratory { get; set; }
        public Swan(string name, int weight, int age, int wingSpan, bool migratory) : base(name, weight, age, wingSpan)
        {
            Migratory = migratory;
        }

    }




    internal class Wolf : Animal
    {
        public string Colour { get; set; }
        public Wolf(string name, int weight, int age, string colour) : base(name, weight, age)
        {
            Colour = colour;
        }


        public override void DoSound()
        {
            Console.WriteLine("Aooooooouuuu");
            //return "Aooooooouuuu";
        }
    }
}
