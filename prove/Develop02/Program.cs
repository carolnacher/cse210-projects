using System;
using System.Collections.Generic;

class Program
{   private static List<Entry> entries = new List<Entry>();
    static void Main(string[] args)
    {
        

        Console.WriteLine("Welcome to the journal online!!");
        int userNumber = -1;
        DisplayMenu();
        userNumber = PromptUserNumber();
        while (userNumber != 5)
        {
            if (userNumber == 1)
            {
                //Call the prompt generator class
                PromptGenerator promptGenerator = new PromptGenerator();
                string randomPrompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine("\nRandom Journal Prompt:");
                Console.WriteLine(randomPrompt);
                Console.WriteLine("Enter your mood: ");
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                string userResponse = Console.ReadLine();
                string mood = Console.ReadLine();
    


                // Create an entry with the random prompt and user's response
                Entry entry = new Entry(date, randomPrompt, userResponse, mood);

                // Add the entry to the entries list
                entries.Add(entry);
               
            }

            if (userNumber == 2)
            {
                //Display all entries of the Entry list
                Console.WriteLine("Journal Entries:");
                foreach (var entry in entries)
                {
                    Console.WriteLine(entry.GetDisplay());
                }
                
            }
            if (userNumber == 3)
            {
                // Load entries from file
                LoadEntriesFromFile();
            
            }

            if (userNumber == 4)
            {
                // Save entries to a file
                SaveEntriesToFile();
                
            }
            // Get the user's choice for the next iteration
            DisplayMenu();
            userNumber = PromptUserNumber();

        }
        // Option 5: Exit the program
        Console.WriteLine("Exiting the program. Goodbye!");
    }

    static int PromptUserNumber()
    {   //read the user input
        Console.Write("Please enter your option: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static void DisplayMenu()
    {
        //Display the menu options
        Console.WriteLine("\nPlease select a option: \n1)- Make an entry\n2)- Display entries\n3)- Load entries from the file\n4)- Save entries to file\n5)- Quit program");
    }
    static void SaveEntriesToFile()
    {
        //create the .txt file
        using (StreamWriter writer = new StreamWriter("entries.txt",true))
        {
            //Create a entries on the file
            foreach (var entry in entries)
            {
                writer.WriteLine(entry.GetDisplay());
                writer.WriteLine();
            }
        }
        Console.WriteLine("Entries saved to file successfully.");
        
    }
    static void LoadEntriesFromFile()
    {
        //Read the file to load all entries
        using (StreamReader reader = new StreamReader("entries.txt"))
        {
            while (!reader.EndOfStream)
            {
                string dateLine = reader.ReadLine();
                string promptLine = reader.ReadLine();
                string responseLine = reader.ReadLine();
                string moodLine = reader.ReadLine();
                reader.ReadLine(); 

                if (dateLine != null && promptLine != null && responseLine != null)
                {
                    // Extract the actual date, prompt, and response from the lines
                    string date = dateLine;
                    string prompt = promptLine;
                    string response = responseLine;
                    string mood = moodLine;

                    // Create an entry and add it to the list
                    Entry entry = new Entry(date, prompt, response, mood);
                    entries.Add(entry);
                }
            }
        }

        Console.WriteLine("\nEntries loaded from file successfully.");

        // Display loaded entries saved

        Console.WriteLine("\nLoaded Entries:");
        foreach (var entry in entries)
        {
            Console.WriteLine(entry.GetDisplay());
        }
    
    }
}
