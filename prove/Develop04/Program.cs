using System;

class Program
{
    static void Main(string[] args)
    {
        while (true) // Loop principal del programa
        {
            Console.Clear(); // Limpia la consola en cada iteración

            // Mostrar menú y permitir al usuario elegir una actividad
            Console.WriteLine("Mindfulness Program Menu");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":

                    BreathingActivity breathingActivity = new BreathingActivity("Breathing Exercise", "Relaxing breathing exercise", 300);
                    Console.WriteLine();
                    Console.WriteLine($"Welcome to {breathingActivity.Name}!");
                    Console.WriteLine();
                    Console.WriteLine(breathingActivity.Description);

                    breathingActivity.PerformBreathingExercise();
                    break;

                case "2":

                    ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Time", "Reflect on life", 180);
                    Console.WriteLine();
                    Console.WriteLine($"Welcome to {reflectionActivity.Name}!");
                    Console.WriteLine();
                    Console.WriteLine(reflectionActivity.Description);
                    Console.WriteLine();
                    string randomPrompt = reflectionActivity.GenerateRandomPrompt();
                    reflectionActivity.DisplayReflectionQuestion(randomPrompt);

                    break;

                case "3":
                    ListingActivity listingActivity = new ListingActivity("Listing Items", "Enumerate items", 120);
                    Console.WriteLine();
                    Console.WriteLine($"Welcome to {listingActivity.Name}!");
                    Console.WriteLine();
                    Console.WriteLine(listingActivity.Description);
                    Console.WriteLine();
                    listingActivity.EnumerateItemsWithCustomTime();
                    break;

                case "4":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }

            Console.WriteLine("\nPress Enter to return to the menu.");
            Console.ReadLine();
        }
    }
}
