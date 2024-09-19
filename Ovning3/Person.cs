using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class Person
    {
        private int age;
        private string fName;
        private string lName;
        private int height;
        private int weight;

        public int Age 
        { 
            get { return age; }
            set
            {
                if (value <= 0)
                {
                    string msg = "Age must be larger than 0!";
                    throw new ArgumentException(msg);
                }
                else
                {
                    age = value;
                }
            }
        }
        public string FName { get { return fName; } set { fName = value; } }
        public string LName { get {return lName; } set { lName = value; } }
        public int Height { get { return height; } set { height = value; } }
        public int Weight { get { return weight; } set { weight = value; } }

    }
}
