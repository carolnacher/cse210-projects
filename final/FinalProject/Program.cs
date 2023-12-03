using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("welcome to fun tasks!! We know that carrying out domestic tasks is the key to assuming responsibility, autonomy and confidence. \nTo make it more fun to implement these habits, let's play!!.\nPlease, tell us your Name:");
        string userName = Console.ReadLine();

        Game game = new Game();
        int choice;

        do
        {
            Console.WriteLine($"{Environment.NewLine}Hello!, {userName}.");
            Console.WriteLine();
            Console.WriteLine("Please choose the activity that you want to do today:");
            Console.WriteLine();
            Console.WriteLine("1. Care the pet");
            Console.WriteLine("2. Make the bed");
            Console.WriteLine("3. Clean the room");
            Console.WriteLine("4. Read scriptures");
            Console.WriteLine("5. Exercise");
            Console.WriteLine("0. Skip");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        PerformTaskWithUserInput(game, new PetCare("This activity consists of taking care of your pet, you must feed it and take it for a walk at least twice a day.", 10, false, 2, "Alimentar ","sacar a pasear al perro."));
                        break;
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        PerformTaskWithUserInput(game, GetTaskByChoice(choice));
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Invalid Option. Try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid Option. Please, Enter a number.");
            }

        } while (choice != 0);

        game.ShowScore();
    }

    static Task GetTaskByChoice(int choice)
    {
        switch (choice)
        {
            case 2:
                return new MakeBed("Make the bed", 5, false, 3);
            case 3:
                return new CleanRoom("Clean the room", 15, false);
            case 4:
                return new ReadScriptures("Read scriptures", 8, false, 30);
            case 5:
                return new Exercise("Exercise", 12, false, 20);
            default:
                return null;
        }
    }

static void PerformTaskWithUserInput(Game game, Task task)
{
    Console.WriteLine($"Activity description: {task.Name}");
    Console.WriteLine($"If you finish the activity you will win: {task.Point} Point.");
    Console.WriteLine("Do you want to continue with the activity? (yes/No)");
    string input = Console.ReadLine().Trim().ToLower();

    if (input == "yes")
    {
        if (!task.IsComplete)
        {
            Console.WriteLine("Did you complete the task? (yes/No)");
            string completionInput = Console.ReadLine().Trim().ToLower();

            if (completionInput == "yes")
            {
                task.MarkComplete();
                Console.WriteLine($"Congratulations! for complete this activity!");
            }
            else
            {
                Console.WriteLine("Oh, I'm sorry! There are difficult days, but it doesn't matter. Try again; we are here waiting to give you the points.");
            }
        }
        else
        {
            Console.WriteLine($"{task.Name} has already been completed.");
        }
    }
    else if (input == "no")
    {
        Console.WriteLine("Oh, I'm sorry! There are difficult days, but it doesn't matter. Try again; we are here waiting to give you the points.");
    }
    else
    {
        Console.WriteLine("Invalid input.");
    }

    game.PerformTask(task);
}

}