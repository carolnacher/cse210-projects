using System;
using System.Collections.Generic;

public class ListingActivity : MindfulnessActivity
{
    public List<string> ListOfItems { get; private set; }

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        Description = "This activity will help you reflect on the good things in your life by listing as many things as you can in a certain area.";
        ListOfItems = new List<string>();
    }

    public string GetRandomPrompt()
    {
        
        string[] prompts =
        {
            "When have you felt the Holy Ghost this month?",
            "Ways you can be a disciple of Christ?",
            "Ways I can serve others?",
        };

        Random random = new Random();
        int index = random.Next(prompts.Length);
        return prompts[index];
        
    }

    public void EnumerateItemsWithCustomTime()
        {
            Console.WriteLine("Enter the duration (in seconds) for enumerating items: ");
            if (int.TryParse(Console.ReadLine(), out int customDuration) && customDuration > 0)
            {
                var startTime = DateTime.Now;
                var endTime = startTime.AddSeconds(customDuration);

                string prompt = GetRandomPrompt();
                List<string> items = new List<string>();

                Console.WriteLine(prompt);
                Console.WriteLine("Press Enter to start.");
                Console.ReadLine();

                Console.WriteLine("The timer has started!");
                Task countdownTask = Task.Run(() =>
                {
                    DisplayCountdown("Time remaining: ", customDuration);
                });

                while (DateTime.Now < endTime)
                {
                    
                    if (DateTime.Now >= endTime)
                        break; 
                    string item = Console.ReadLine();    
                    items.Add(item);
                }

                countdownTask.Wait(); 

                Console.WriteLine("Time's up! Your items:");

                foreach (var item in items)
                {
                    DisplayItem(item);
                }

                Console.WriteLine();
                Console.WriteLine("Congratulations! You've completed the Listing Activity.");
                Console.WriteLine();
                DisplayEndMessage();
            }
            else
            {
                Console.WriteLine("Invalid duration. Please enter a positive number of seconds.");
            }
        }


    public void DisplayItem(string item)
    {
        Console.WriteLine($"- {item}");
    }

    
}