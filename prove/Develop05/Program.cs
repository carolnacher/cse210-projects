using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        User user = new User();
        Goal myGoal = new SimpleGoal("Example Goal", "Description", 10);

        int choice;
        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1) Create new Goal");
            Console.WriteLine("2) List of Goals");
            Console.WriteLine("3) Check the Goal");
            Console.WriteLine("4) Show your score");
            Console.WriteLine("5) Save goals");
            Console.WriteLine("6) Load goals");
            Console.WriteLine("7) Quit");

            Console.WriteLine();
            Console.Write("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        user.CreateGoal();
                        break;
                    case 2:
                        user.DisplayGoals();
                        break;
                    case 3:
                        user.RecordEvent();
                        
                        break;
                    case 4:
                        user.ShowScore();
                        break;
                    case 5:
                        user.SaveGoals();
                        break;
                    case 6:
                        user.LoadGoals();
                        break;
                    case 7:
                        Console.WriteLine("Exiting the program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

        } while (choice != 7);
    }
}

// Resto del código (clases User, Goal, SimpleGoal, etc.)...
