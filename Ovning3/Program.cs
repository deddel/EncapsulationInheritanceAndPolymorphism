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
                    //Test data
                    Person p1 = new Person(8, "Alexander", "Lukas", 176, 70);
                    Person p2 = new Person(15, "Farmor", "Anka", 165, 63);
                    
                    //Uncomment one of theese at a time
                    //Person p3 = new Person(9, null, "Anka", 165, 63);
                    //Person p3 = new Person(9, "", "Anka", 165, 63);
                    //Person p3 = new Person(9, "K", "Anka", 165, 63);
                    //Person p3 = new Person(9, "Kalle", "A", 165, 63);
                    //Person p3 = new Person(9, "Kalle", "", 165, 63);
                    //Person p3 = new Person(9, "Kalle", null, 165, 63);
                    
                    //Checking access
                    p1.FName = "Farbror"; //Ja man kommer åt properties men inte de privata fälten
                    p1.LName = "Joakim";
                    p1.Age = 12;
                    p1.Height = 168;
                    p1.Weight = 69;
                    //p1.age = 12; //Error: Person.age is inaccessible due to its protection level         
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
                        Console.WriteLine("No exeption errors");
                        isRunning = false;
                }
                
            }
        }
    }
}
