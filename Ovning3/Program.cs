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
                    Person p = new Person();
                    p.LName = "Lukas";
                    p.FName = "Alexander"; //Ja man kommer åt properties men inte de privata fälten
                    p.Age = -1;
                    p.Height = 176;
                    p.Weight = 70;
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
                }
                
            }
        }
    }
}
