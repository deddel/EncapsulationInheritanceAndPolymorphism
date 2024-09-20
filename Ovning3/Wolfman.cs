using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class Wolfman : Wolf , IPerson
    {
        

        public Wolfman(string name, int weight, int age, string colour) : base(name, weight, age, colour)
        {
        }

        //public void Talk(string qoute = "My lips are sealed!")
        //{
        //    Console.WriteLine(quote);
        //}

        public void Talk(string qoute)
        {
            Console.WriteLine(value: qoute);
        }

        //public string Quote { get; set; }

        //public string Talk()
        //{
        //    Console.WriteLine("quote"); ;
        //}
    }
}
