using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class PersonHandler
    {
        public static void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public static Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person pers = new Person(age, fname, lname, height, weight);
            return pers;
        }

        public static void TalkToPerson(Person pers)
        {
            Console.WriteLine($"Howdy, nice to meet you! My name is {pers.FName}. I am {pers.Age} years old." +
                $"I was hoping you could help with my duties.");
        }
    }


}
