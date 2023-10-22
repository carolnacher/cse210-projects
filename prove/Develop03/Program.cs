using System;

class Program
{
   private static ScriptureLibrary library = new ScriptureLibrary();

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the scripture memorizer");

        while (true)
        {
            Console.WriteLine("Select a option:\n");
            Console.WriteLine("1. Add new scripture");
            Console.WriteLine("2. Practice with an existing Scripture");
            Console.WriteLine("3. Quit\n");
            Console.Write("Option: ");

            if (int.TryParse(Console.ReadLine(), out int option))
            {
                switch (option)
                {
                    case 1:
                        library.AddNewScripture();
                        break;
                    case 2:
                        library.PracticeRandomScripture();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }
    }

   
   
}


