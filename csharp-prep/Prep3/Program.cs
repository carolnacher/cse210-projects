using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        string decision = ""; 

        
        Console.WriteLine("Hello!, Do you want to play Guess My Number? (yes/no)");
        decision = Console.ReadLine();

        while (decision == "yes")
        {

            int user= -1;
        

        
            while (user != number)
            {
                Console.WriteLine("What is the number");
                user = int.Parse(Console.ReadLine());
                if (number>user)
                {
                    Console.WriteLine("Higher");
                }
                else if(number<user)
                {
                    Console.WriteLine("Lower");
                }
                else {
                    
                    Console.WriteLine("It's correct!!");
                    Console.WriteLine("Would you like to continue playing Guess My Number? (yes/no)");

                    decision = Console.ReadLine();
                }
                
            }
 
        }
        
        Console.WriteLine("oh. It's so sad!! see you the next timet");
    }


}