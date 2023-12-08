using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("\nWelcome to fun tasks!! We know that carrying out domestic tasks is the key to assuming responsibility, autonomy, and confidence. \nTo make it more fun to implement these habits, let's play!!.\n \nPlease, tell us your Name:");
        string userName = Console.ReadLine();

        Game game = new Game();
        int choice;

        do
        {
            Console.WriteLine($"{Environment.NewLine}Hello!, {userName}.");
            Console.WriteLine();
            game.ShowScore();
            Console.WriteLine();
            Console.WriteLine("Please choose the activity that you want to do today to continue adding to your score:");
            Console.WriteLine();
            Console.WriteLine("1. Care the pet");
            Console.WriteLine("2. Make the bed");
            Console.WriteLine("3. Clean the room");
            Console.WriteLine("4. Read scriptures");
            Console.WriteLine("5. Exercise");
            Console.WriteLine("0. Skip\n");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        PerformTaskWithUserInput(game, new PetCare("Our pets not only become another member of the family, they also teach us to be more sociable, responsible and aware of other living beings. That's why you must follow these 3 steps: 1) make sure that your pet has water, 2) feed it 3) play with your pet and take her for a walk.", 10, false, 2, "Feed", "Take the dog for a walk"));
                        Console.WriteLine();
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

        
    }

    static Task GetTaskByChoice(int choice)
    {
        switch (choice)
        {
            case 2:
                return new MakeBed("Making the bed brings great benefits, not only does it contribute to our physical well-being, it also helps us sleep better, making the bed also contributes to our mental balance. An orderly environment helps us organize our mind \n", 5, false, 3);
                
            case 3:
                return new CleanRoom("In this activity you must 1) gather what is on the floor 2) take out the dirty clothes 3) sweep the floor of the room 4) ventilate.\n", 15, false);
            case 4:
                return new ReadScriptures("Read scriptures\n", 100, false, 30);
            case 5:
                int defaultMinutes = 0;
                return new Exercise("Getting regular physical activity can help keep your thinking, learning, and judgment skills strong as you age. It can also reduce your risk of depression and anxiety, as well as help you sleep better.\n", 12, false, 20, defaultMinutes);
            default:
                return null;
        }
    }

static void PerformTaskWithUserInput(Game game, Task task)
{
    Console.WriteLine($"Activity description: {task.Name}");
    Console.WriteLine($"\nIf you finish the activity you will win: {task.Point} Point.");

    Console.WriteLine("\nDo you want to continue with the activity? (yes/No)");
    string input = Console.ReadLine().Trim().ToLower();
   
    if (input == "yes")
    {
        if (!task.IsComplete)
        {
            Console.WriteLine("Enter the duration of the task in seconds:");
            if (int.TryParse(Console.ReadLine(), out int durationInSeconds))
            {
                Console.WriteLine($"You have {durationInSeconds} seconds to complete the task.");

                game.DisplayCountdown("Time left: ", durationInSeconds);

                Console.WriteLine("Did you complete the task? (yes/No)");
                string completionInput = Console.ReadLine().Trim().ToLower();

                if (completionInput == "yes")
                {
                    if (!task.IsComplete)
                    {
                        task.MarkComplete();
                        game.PerformTask(task);
                        Console.WriteLine($"Congratulations! for completing this activity!");

                        
                        if (task is ReadScriptures)
                        {   
                            Console.WriteLine("\nWhat scripture did you like the most?\n");
                            ((ReadScriptures)task).FavoriteScripture = Console.ReadLine();

                            Console.WriteLine("\nWhat did you learn from this scripture?\n");
                            ((ReadScriptures)task).Learned = Console.ReadLine();
                            SaveReadScripturesInfo((ReadScriptures)task);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{task.Name} has already been completed.");
                    }
                }
                else
                {
                    Console.WriteLine("\nOh, I'm sorry! There are difficult days, but it doesn't matter. Try again; we are here waiting to give you the points.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for duration. Activity will be considered incomplete.");
            }
        }
        else
        {
            Console.WriteLine($"you are closer to achieving the goal");
        }
    }
    else if (input == "no")
    {
        Console.WriteLine("Oh, I'm sorry! There are difficult days, but it doesn't matter. You can try another activity.");
    }
    else
    {
        Console.WriteLine("Invalid input.");
    }
}

 private static void SaveReadScripturesInfo(ReadScriptures readScriptures)
    {
        
        string fileName = "study_scriptures.txt";
        DateTime now = DateTime.Now;
       
        string content = $"Favorite Scripture: {readScriptures.FavoriteScripture}\n";
        content += $"What I Learned: {readScriptures.Learned}\n";
        content += $"Date: {now}\n\n";

        
        System.IO.File.AppendAllText(fileName, content);
    }
    
}