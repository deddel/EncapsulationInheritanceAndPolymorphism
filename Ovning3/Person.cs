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

        public Person(int age, string fName, string lName, int height, int weight)
        {
            Age = age;
            FName = fName;
            LName = lName;
            Height = height;
            Weight = weight;
        }

        public int Age 
        { 
            get { return age; }
            set
            {
                if (value <= 0)
                {
                    string exMsg = "Age must be larger than 0 !!";
                    throw new ArgumentException(exMsg);
                }
                else
                {
                    age = value;
                }
            }
        }
        public string FName
        { 
            get { return fName; } 
            set 
            {
                //if (value == null || value =="")
                if (string.IsNullOrEmpty(value))
                {
                    string exMsg = "FName can not be null or empty!!";
                    throw new ArgumentException(exMsg);
                }
                else if (value.Length < 2 || value.Length > 10)
                {
                    string exMsg = "FName must be between 2 and 10 charachters !!";
                    throw new ArgumentException(exMsg);
                }
                else
                    fName = value;
            } 
        }
        public string LName
        { 
            get { return lName; } 
            set 
            {
                //if (value == null || value =="")
                if (string.IsNullOrEmpty(value))
                {
                    string exMsg = "LName can not be null or empty!!";
                    throw new ArgumentException(exMsg);
                }
                else if (value.Length < 3 || value.Length > 15)
                {
                    string exMsg = "LName must be between 3 and 15 charachters !!";
                    throw new ArgumentException(exMsg);
                }
                else
                    lName = value;
            } 
        }
        public int Height { get { return height; } set { height = value; } }
        public int Weight { get { return weight; } set { weight = value; } }

    }
}
