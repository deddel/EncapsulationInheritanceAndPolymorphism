﻿using System.Net.NetworkInformation;

namespace Ovning3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            
            while (isRunning) 
            {
                try
                {
                    /*3.1.1*/
                    //Testing Person class
                    //Person p1 = new Person(8, "Alexander", "Lukas", 176, 70);
                    //Person p2 = new Person(15, "Farmor", "Anka", 165, 63);

                    //Uncomment one of theese at a time
                    //Person p3 = new Person(9, null, "Anka", 165, 63);
                    //Person p3 = new Person(9, "", "Anka", 165, 63);
                    //Person p3 = new Person(9, "K", "Anka", 165, 63);
                    //Person p3 = new Person(9, "KalleKalleKalle", "Anka", 165, 63);
                    //Person p3 = new Person(9, "Kalle", "A", 165, 63);
                    //Person p3 = new Person(9, "Kalle", "AnkaAnkaAnkaAnkaAnka", 165, 63);
                    //Person p3 = new Person(9, "Kalle", "", 165, 63);
                    //Person p3 = new Person(9, "Kalle", null, 165, 63);

                    //Checking access, uncomment p1 above
                    //p1.FName = "Joakim"; //Ja man kommer åt properties men inte de privata fälten
                    //p1.LName = "Von Anka";
                    //p1.Age = 12;
                    //p1.Height = 168;
                    //p1.Weight = 69;
                    //p1.age = 12; //Error: Person.age is inaccessible due to its protection level         

                    /*3.1.2-3.1.5*/
                    //Testing PersonHandler class
                    //Person p4 = PersonHandler.CreatePerson(10, "Opfinnar", "Jocke", 179, 71);
                    //Person p5 = PersonHandler.CreatePerson(13, "Pontus", "Von Pluring", 171, 66);
                    //Person p6= PersonHandler.CreatePerson(9, "Kommisarie", "Karlsson", 174, 95);
                    //Person p7= PersonHandler.CreatePerson(8, "Magica", "de Hex", 164, 59);
                    //PersonHandler.SetAge(p4, 11);  /*3.1.2*/
                    //PersonHandler.TalkToPerson(p7); /*3.1.4*/

                    /*3.2*/
                    List<UserError> userErrors = new List<UserError>();
                    userErrors.Add(new NumericInputError());
                    userErrors.Add(new TextInputError());
                    userErrors.Add(new TextInputError());
                    userErrors.Add(new NumericInputError());
                    userErrors.Add(new TextInputError());

                    foreach (UserError err in userErrors)
                    {
                        Console.WriteLine(err.UEMessage());
                    }

                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.ToString());
                    isRunning = false;
                }
                finally
                {
                    if (isRunning == false)
                        Console.WriteLine("There was an exception error. Stopping program");
                    else 
                        //Console.WriteLine("No exeption errors");
                        isRunning = false;
                }
                
            }
        }
    }
}
