using System;

public class MindfulnessActivity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Duration { get; set; }

   
    public MindfulnessActivity(string name, string description, int duration)
    {
        Name = name;
        Description = description;
        Duration = duration;
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine($"-Finished {Name}. - Duration: {Duration} seconds.");
    }
       public void ContDown(string message, int seconds)
    {   Console.Write(message);
            for(int index = seconds; index>0; index--)
            {
                Console.Write(index);
                Thread.Sleep(1000);
                Console.Write("\b");

            }
        Console.Write("\r");
    }

     public void SetDurationFromUserInput()
    {
        Console.Write("Enter the duration (in seconds): ");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            Duration = duration;
        }
        else
        {
            Console.WriteLine("Invalid input. Duration must be a positive integer.");
        }
    }

    public void DisplayCountdown(string message, int seconds)
{
    Console.WriteLine(message);
    for (int i = seconds; i > 0; i--)
    {
        Console.Write($"{i} seconds... ");
        System.Threading.Thread.Sleep(1000); // Espera 1 segundo
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, Console.CursorTop);
    }
    Console.WriteLine();

}
 public void DisplaySpinner()
    {

        for (int i = 0; i < Duration; i++)
        {
            if (i >= Duration)
                break;

            Console.Write("  /  "); Thread.Sleep(250); Console.Write("\r");
            Console.Write("  -  "); Thread.Sleep(250); Console.Write("\r");
            Console.Write("  \\  "); Thread.Sleep(250); Console.Write("\r");
            Console.Write("  |  "); Thread.Sleep(250); Console.Write("\r");

        }

}
}


