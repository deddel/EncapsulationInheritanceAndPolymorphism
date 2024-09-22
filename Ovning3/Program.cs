using System.Net.NetworkInformation;
//using DogExtensions;

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
                    #region 3.1
                    /*3.1.1*/
                    //Testing Person class
                    //Person p1 = new Person(8, "Alexander", "Lukas", 176, 70);
                    //Person p2 = new Person(15, "Farmor", "Anka", 165, 63);

                    //Checking access, uncomment p1 above
                    //p1.FName = "Joakim"; //Ja man kommer åt properties men inte de privata fälten
                    //p1.LName = "Von Anka";
                    //p1.Age = 12;
                    //p1.Height = 168;
                    //p1.Weight = 69;
                    //p1.age = 12; //Error: Person.age is inaccessible due to its protection level 

                    //Only uncomment one of these at a time.
                    //Person p3 = new Person(9, null, "Anka", 165, 63);
                    //Person p3 = new Person(9, "", "Anka", 165, 63);
                    //Person p3 = new Person(9, "K", "Anka", 165, 63);
                    //Person p3 = new Person(9, "KalleKalleKalle", "Anka", 165, 63);
                    //Person p3 = new Person(9, "Kalle", "A", 165, 63);
                    //Person p3 = new Person(9, "Kalle", "AnkaAnkaAnkaAnkaAnka", 165, 63);
                    //Person p3 = new Person(9, "Kalle", "", 165, 63);
                    //Person p3 = new Person(9, "Kalle", null, 165, 63);

                    /*3.1.2-3.1.5*/
                    //Testing PersonHandler class
                    //Person p4 = PersonHandler.CreatePerson(10, "Opfinnar", "Jocke", 179, 71);
                    //Person p5 = PersonHandler.CreatePerson(13, "Pontus", "Von Pluring", 171, 66);
                    //Person p6= PersonHandler.CreatePerson(9, "Kommisarie", "Karlsson", 174, 95);
                    //Person p7= PersonHandler.CreatePerson(8, "Magica", "de Hex", 164, 59);
                    //PersonHandler.SetAge(p4, 11);  /*3.1.2*/
                    //PersonHandler.TalkToPerson(p7); /*3.1.4*/
                    #endregion

                    #region 3.2
                    //List<UserError> userErrors = new List<UserError>();
                    //userErrors.Add(new NumericInputError());
                    //userErrors.Add(new TextInputError());
                    //userErrors.Add(new TextInputError());
                    //userErrors.Add(new NumericInputError());
                    //userErrors.Add(new TextInputError());
                    //userErrors.Add(new TooSlowError());
                    //userErrors.Add(new AttitudeError());
                    //userErrors.Add(new NumberTooLargeError());

                    //foreach (UserError err in userErrors)
                    //{
                    //    Console.WriteLine(err.UEMessage());
                    //}
                    #endregion

                    #region 3.3
                    //Testdata
                    Animal horse = new Horse("Copiad", 550, 23, 56);
                    Animal dog1 = new Dog("Pluto", 16, 9, "Bloodhound");
                    Animal dog2 = new Dog("Goofy", 50, 10, "Wolfdog");
                    Animal dog3 = new Dog("Lady", 6, 8, "American Cocker Spaniel");
                    Animal hedgeHog = new Hedgehog("Harry", 1, 5, 5600);
                    Animal worm = new Worm("Willy", 1, 3, false);
                    Animal bird = new Bird("Donald Duck", 1, 6, 81);
                    Animal wolf = new Wolf("Akela", 25, 10, "grey");
                    Animal pelican = new Pelican("Pelle", 4, 12, 210, "Great white pelican");
                    Animal flamingo = new Flamingo("Florence", 3, 11, 145, "North America");
                    Animal swan = new Swan("Sweetie", 9, 7, 200, true);
                    Wolfman wolfman = new Wolfman("Lawrence Talbot", 80, 43, "Dark grey");

                    //Test of IPerson reference & wolfman.Talk()
                    //IPerson wolfman = new Wolfman("Lawrence Talbot", 80, 43, "Dark grey");
                    //wolfman.Talk("I wish things were different.");

                    //Answer to Question 3.3.13: The Bird class
                    
                    //Answer to Question 3.3.14: The Animal class
                    #endregion

                    #region 3.4

                    //3.4.3
                    List<Animal> Animals = new List<Animal>();
                    //3.4.4
                    Animals.Add(horse);
                    Animals.Add(dog1);
                    Animals.Add(dog2);
                    Animals.Add(dog3);
                    Animals.Add(hedgeHog);
                    Animals.Add(worm);
                    Animals.Add(bird);
                    Animals.Add(wolf);
                    Animals.Add(pelican);
                    Animals.Add(flamingo);
                    Animals.Add(swan);
                    Animals.Add(bird);
                    Animals.Add(wolfman);

                    //3.4.5-7
                    //foreach (Animal animal in animals) 
                    //{
                    //    Console.Write($"{animal.GetType().Name}, ");
                    //    if (animal is IPerson castedToWolfman) 
                    //    {
                    //        castedToWolfman.Talk("I wish things were different."); 
                    //    }
                    //    animal.DoSound();
                    //    Console.WriteLine();
                    //}

                    //3.4.8
                    List<Dog> dogs = new List<Dog>();
                    //3.4.9
                    //dogs.Add(horse); 

                    //Answer to Question 3.4.9: Not possible because Dog and Horse
                    //are separate classes and both inherits from Animal but have no
                    //direkt relation to each other.

                    //Answer to Question 3.4.10: The list must be of type Animal.

                    //3.4.11-12
                    Console.WriteLine("Animals: ");
                    foreach (Animal animal in Animals)
                    {
                        Console.Write($"{animal.GetType().Name}, ");
                        Console.WriteLine(animal.Stats());
                        Console.WriteLine();
                    }
                    //Answer to Question 3.4.13: 
                    //The foreach loops through each Animal-object in the Animals list.
                    //The on each object assigned to the variable animal the loop prints 
                    //the name of the class followed by the respective property names and their values.

                    //3.4.14
                    Console.WriteLine("Dogs: ");
                    foreach (Animal animal in Animals)
                    {
                        if (animal.GetType() == typeof(Dog))
                        {
                            Console.Write($"{animal.GetType().Name}, ");
                            Console.WriteLine(animal.Stats());
                            Console.WriteLine();

                        }
                    }

                    //3.4.16
                    //Not accessible

                    //Answer to Question 3.4.17:
                    //The Animal class have no knowledge of the method, since 
                    //Animal does not know of the Dog class and have no acces to it's methods

                    //3.4.18 use extension method for DogOutputString
                    Console.WriteLine("DogOutputString method: ");
                    foreach (Animal animal in Animals)
                    {
                        if (animal.GetType() == typeof(Dog))
                        {
                            Console.Write($"{animal.GetType().Name}, ");
                            //Console.WriteLine(animal.Dog.DogOutputString("Man's best friend")); 
                            //Not accessible
                            Console.WriteLine(animal.DogOutputString("Man's best friend."));

                            Console.WriteLine();
                        }
                    }
                    //Console.WriteLine(dog1.Dog.DogOutputString("Man's best friend")); //Not accessible
                    #endregion

                }

                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.ToString());
                    isRunning = false;
                }
                finally
                {
                    if (isRunning == false)
                        Console.WriteLine("An argument exception error was fired. Stopping program");
                    else
                        //Console.WriteLine("No exeption errors");
                        isRunning = false;
                }
                
            }
        }
    }
}
