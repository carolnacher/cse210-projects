using System;
using System.Collections.Generic;
using System.Data.SqlTypes;

public class Journal{

    public void DisplayMenu()
    {
        //Display the menu options
        Console.WriteLine("\nPlease select a option: \n1)- Make an entry\n2)- Display entries\n3)- Load entries from the file\n4)- Save entries to file\n5)- Quit program");
    }

     public int PromptUserNumber()
    {   
        Console.Write("Please enter your option: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

  
     public void LoadEntriesFromFile(List<Entry> entries)
    {
    
        using (StreamReader reader = new StreamReader("entries.txt"))
        {
            while (!reader.EndOfStream)
            {
                string dateLine = reader.ReadLine();
                string promptLine = reader.ReadLine();
                string responseLine = reader.ReadLine();
                string moodLine = reader.ReadLine();
                
                
                reader.ReadLine(); 

                if (dateLine != null && promptLine != null && responseLine != null && moodLine != null)
                {
                    
                    string date = dateLine;
                    string prompt = promptLine;
                    string response = responseLine;
                    string mood = moodLine; 

                    
                    Entry entry = new Entry(date, prompt, response, mood);
                    entries.Add(entry);
                }
            }
        }

        Console.WriteLine("\nEntries loaded from file successfully.");

        

        Console.WriteLine("\nLoaded Entries:");
        foreach (var entry in entries)
        {
            Console.WriteLine(entry.GetDisplay());
        }
    
    }


     public void SaveEntriesToFile(List<Entry> entries)
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


   } 
