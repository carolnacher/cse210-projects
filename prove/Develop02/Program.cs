using System;
using System.Collections.Generic;
using System.Dynamic;

class Program
{   private static List<Entry> entries = new List<Entry>();
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the journal online!!");
        Journal journal = new Journal();
        Weather todayWeather = new Weather("Salt Lake City", 20.0);
       
        journal.DisplayMenu();
        int userNumber=journal.PromptUserNumber();
        
        
        while (userNumber != 5)
        {
            if (userNumber == 1)
            {
                //Call the prompt generator class
                PromptGenerator promptGenerator = new PromptGenerator();
                string randomPrompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine("\nRandom Journal Prompt:");
                Console.WriteLine(randomPrompt);
                
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                string userResponse = Console.ReadLine();

                Console.WriteLine("Enter your mood: ");
                string mood = Console.ReadLine();


                // Create an entry with the random prompt and user's response
                Entry entry = new Entry(date, randomPrompt, userResponse, mood);

                // Add the entry to the entries list
                entries.Add(entry);

                 Console.WriteLine($"Today's Weather in {todayWeather.Location}:");
                 Console.WriteLine($"Temperature: {todayWeather.Temperature}°C");
           
               
            }

            if (userNumber == 2)
            {
                Console.WriteLine("\nJournal Entries:\n");
                foreach( var entry in entries)
            {
                Console.WriteLine(entry.GetDisplay());
            }
                
            }
            if (userNumber == 3)
            {
                journal.LoadEntriesFromFile(entries);
            
            }

            if (userNumber == 4)
            {
                
                journal.SaveEntriesToFile(entries);
                
            }
            
            journal.DisplayMenu();
            userNumber = journal.PromptUserNumber();

        }
        // Option 5: Exit the program
        Console.WriteLine("Exiting the program. Goodbye!");
    }

    

    
    

}
